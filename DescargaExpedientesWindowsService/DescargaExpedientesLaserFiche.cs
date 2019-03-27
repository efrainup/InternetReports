using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using Hinojosa.RepositorioDocumentos;
using Hinojosa.RepositorioDocumentos.Laserfiche;
using LFSO100Lib;
using System.IO;
using System.Xml;
using System.Net.Mail;
using System.Diagnostics;
using System.Configuration;

namespace DescargaExpedientesWindowsService
{
    public partial class DescargaExpedientesLaserFiche : ServiceBase
    {
        public MessageQueue ColaDeMensajesDeSolicitudes { get; set; }
        Laserfiche.RepositoryAccess.Session sesion;
        IAsyncResult ar;
        SolicitudesDbContext context;
        System.Timers.Timer timer1;
        string server;
        string database;
        string user;
        string password;
        public string DirectorioDescargas { get; set; }

        public DescargaExpedientesLaserFiche()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            server   = ConfigurationManager.AppSettings["LFServidor"];
            database = ConfigurationManager.AppSettings["LFRepositorio"];
            user     = ConfigurationManager.AppSettings["LFUsuario"];
            password = ConfigurationManager.AppSettings["LFPassword"];
            DirectorioDescargas = ConfigurationManager.AppSettings["DirectorioDescargas"];

            timer1 = new System.Timers.Timer();

            context = new SolicitudesDbContextFactory().Create();
            timer1.Interval = 5000;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Elapsed += timerReadMessageQueue_Tick;
            
            

        }

      

        private void ColaDeMensajesDeSolicitudes_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            try
            {
                ((MessageQueue)sender).EndReceive(e.AsyncResult);
                Message solicitud = e.Message;
                
                var formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                solicitud.Formatter = formatter;
                System.Xml.XmlDocument xmlDocument = new System.Xml.XmlDocument();
                xmlDocument.LoadXml(solicitud.Body.ToString());

                Solicituddescargamasiva objetoSolicitud = new Solicituddescargamasiva();
                objetoSolicitud.NombreSolicitud = xmlDocument.SelectSingleNode("/SolicitudDescargaMasiva/NombreSolicitud").InnerText;
                objetoSolicitud.FechaInicio = Convert.ToDateTime(xmlDocument.SelectSingleNode("/SolicitudDescargaMasiva/FechaInicio").InnerText);
                objetoSolicitud.FechaFin = Convert.ToDateTime(xmlDocument.SelectSingleNode("/SolicitudDescargaMasiva/FechaFin").InnerText);
                objetoSolicitud.IdCliente = xmlDocument.SelectSingleNode("/SolicitudDescargaMasiva/IdCliente").InnerText;

                ProcesarSolicitud(objetoSolicitud);
            }
            catch
            {

            }
            
            ar = ColaDeMensajesDeSolicitudes.BeginReceive();
        }

        private void ProcesarSolicitud(Solicituddescargamasiva objetoSolicitud)
        {


           //bool conWindows = Convert.ToBoolean(ConfigurationManager.AppSettings["AutenticarLFConWindows"]);
           //if (!conWindows)
           //{
           //    sesion = Laserfiche.RepositoryAccess.Session.Create(server, database, user, password);
           //}
           //else
           //{
                sesion = Laserfiche.RepositoryAccess.Session.Create(server, database);
            //}
            try
            {

                IArchivosAltContext2 archivosAltContext = new ArchivosAltContext2Factory().Create();
                List<SqPedimentosSirSaaiReturnModel> lista = archivosAltContext.SqPedimentosSirSaai(objetoSolicitud.FechaInicio.ToString("MM/dd/yyyy"), objetoSolicitud.FechaFin.ToString("MM/dd/yyyy"), Convert.ToInt32(objetoSolicitud.IdCliente), null, 1);


                
                IBuscadorDocumentos<DocumentoRepositorio> buscador = new Hinojosa.RepositorioDocumentos.Laserfiche.BuscadorDocumentosLaserficheRepositoryAccess(sesion);
                IEnumerable<DocumentoRepositorio> documentoRepositorios = buscador.BuscarDocumentosExpediente(lista.Select(s => s.Referencia).ToArray(), null);

                
                //Crear carpeta de la solicitud
                DirectoryInfo directoryInfo = new DirectoryInfo($@"{DirectorioDescargas}{objetoSolicitud.NombreSolicitud}");
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                }

                //bool nombrePorPedimento = true;


                IExportadorDocumentos<DocumentoRepositorio> exportador = new Hinojosa.RepositorioDocumentos.Laserfiche.ExportadorDocumentosLaserficheRepositoryAccess(sesion);
                exportador.Exportar(documentoRepositorios, $@"{DirectorioDescargas}{objetoSolicitud.NombreSolicitud}", true, (d) =>
                {
                   //if (!nombrePorPedimento)
                   //{
                   //    int dr = d.Ruta.IndexOf(d.Referencia);
                   //    return d.Ruta.Substring(dr, (d.Ruta.Length - dr) - (d.Ruta.Length - d.Ruta.LastIndexOf("\\")));
                   //}
                   //else
                   //{
                        int dr = d.Ruta.IndexOf(d.Referencia);
                        string subcarpeta = d.Ruta.Substring(dr + d.Ruta.Substring(dr).IndexOf("\\"));
                    subcarpeta = subcarpeta.Substring(0, subcarpeta.LastIndexOf("\\"));




                    var datosPedimento = lista.First(f => f.Referencia == d.Referencia);
                        return $"{datosPedimento.FechaPago.Substring(8, 2)}{datosPedimento.Aduana}{datosPedimento.Seccion}{datosPedimento.Patente}{datosPedimento.Pedimento}{subcarpeta}";
                   // }
                    //return d.Pedimento;
                });

                objetoSolicitud.Procesado = true;
                objetoSolicitud.FechaProcesado = DateTime.Now;
                objetoSolicitud.RutaArchivo = DirectorioDescargas + objetoSolicitud.NombreSolicitud + ".zip";

                context.SaveChanges();

                //Se envía correo al interesado

                //Ver archivo de configuración ya que ahí se encuentra configurado el correo de salida
                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
                clienteSmtp.Credentials = new System.Net.NetworkCredential("Dahinojosa.alertas@gmail.com", "da.hinojosa");
                clienteSmtp.EnableSsl = true;

                string remitente = System.Configuration.ConfigurationManager.AppSettings["SMTPRemitente"];
                MailMessage correo = new MailMessage(remitente, objetoSolicitud.Notificar);
                correo.Body = $"Estimado cliente, le notificamos que la descarga de sus expedientes con folio: {objetoSolicitud.NombreSolicitud} se encuentra disponible para su descarga. Puede ingresar al portal de clientes D.A. Hinojosa para realizar la descarga del mismo a través de este link.\r\n\r\nAtt. Grupo Hinojosa";
                

                clienteSmtp.Send(correo);


            }
            catch (Exception exc)
            {
                Trace.TraceError(exc.ToString());
                try
                {
                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
                    clienteSmtp.Credentials = new System.Net.NetworkCredential("Dahinojosa.alertas@gmail.com", "da.hinojosa");
                    clienteSmtp.EnableSsl = true;

                    string remitente = System.Configuration.ConfigurationManager.AppSettings["SMTPRemitente"];
                    MailMessage correo = new MailMessage(remitente, "Analista.Programador@hinojosa.com.mx");
                    correo.Body = $"Error en descarga LF: {exc.ToString()} ";


                    clienteSmtp.Send(correo);
                }catch(Exception e)
                {

                }
            }
            finally
            {
                if (sesion.IsConnected)
                {
                    sesion.Close();
                }
            }
        }

        protected override void OnStop()
        {
            if (sesion != null && sesion.IsConnected)
            {
                sesion.Close();
            }
        }

        private void timerReadMessageQueue_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            var s = context.Solicituddescargamasivas.FirstOrDefault(f => f.Procesado == false);
            if (s != null)
            {
                ProcesarSolicitud(s);
            }

            timer1.Start();
        }
    }
}

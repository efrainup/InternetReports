using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hinojosa.RepositorioDocumentos;
using LFSO100Lib;

namespace ConsoleApp1
{
    class Program
    {
        protected static  ILFConnection conexionLF = new LFConnection();
        protected static  ILFApplication aplicacionLF;
        protected static  ILFServer servidorLF;
        protected static  ILFDatabase baseDeDatosLF;

        static void Main(string[] args)
        {
            string server = "ServerWA";
            string database = "DA-HINOJOSA";
            string user = "ADMIN";
            string password = "A12345678";

            //conexionLF.UserName = user;
            //conexionLF.Password = password;

            //aplicacionLF = new LFApplication();
            //servidorLF = aplicacionLF.GetServerByName(server);
            //baseDeDatosLF = servidorLF.GetDatabaseByName(database);

            //conexionLF.Create(baseDeDatosLF as LFDatabase);

            //ILFEntry entry = baseDeDatosLF.GetEntryByID(15427778);

            //LFDocument documentoLaserfiche = entry as LFDocument;

            ////documentoLaserfiche.ElectFile.
            //documentoLaserfiche.ElectFile.ReadStream.Open();
            //documentoLaserfiche.ElectFile.ReadStream.Export("C:\\DescargasDanfoss\\" + documentoLaserfiche.Name + "." + documentoLaserfiche.ElectFile.Extension);
            //documentoLaserfiche.ElectFile.ReadStream.Close();

            //conexionLF.Terminate();
            //Laserfiche.RepositoryAccess.Session a = null;
            //try
            //{
            //     a = Laserfiche.RepositoryAccess.Session.Create(server, database, user, password);
            //    if (!a.IsConnected)
            //    {
            //        a.Connect(a.Repository);
            //    }

            //    var doc = Laserfiche.RepositoryAccess.Document.GetDocumentInfo(15427778, a);

            //    var s = new Laserfiche.RepositoryAccess.Search(a);
            //    var set = new Laserfiche.RepositoryAccess.SearchListingSettings();
            //    set.EntryFilter = Laserfiche.RepositoryAccess.EntryTypeFilter.Folders;
            //    set.FollowShortcuts = false;
            //    set.AddColumn(Laserfiche.RepositoryAccess.SystemColumn.Id);

            //    s.Command = "{LF:Name=\"1808777-00\",Type=\"F\" } & ({LF:ParentName=\"IMPO\"}|{LF:ParentName=\"EXPO\"})";
            //    s.BeginRun(true);

            //    var t = new Laserfiche.RepositoryAccess.BriefcaseExporter(a);

            //    var rl = s.GetResultListing(set);
            //    for(int i = 1; i <= rl.RowsCount; i++)
            //    {
            //        var entryInfor = rl.GetEntryInfo(i);
            //        //t.AddEntry(entryInfor);
            //        NewMethod(a, entryInfor);
            //    }
            //    //t.Version = Laserfiche.RepositoryAccess.BriefcaseFormat.Default;
            //    //t.PreserveFolderStructure = true;
            //    //t.Export("C:\\DescargarDanfoss\\briefcase.zip");
            //    //t.Close();
            //    //new Laserfiche.RepositoryAccess.EntryListingSettings

            //    //doc.ReadEdoc().e
            //    //Laserfiche.RepositoryAccess.StreamRange

            //    //var de = new Laserfiche.DocumentServices.DocumentExporter();
            //    //de.ExportElecDoc(doc, "C:\\DescargarDanfoss\\" + doc.Name +"."+ doc.Extension);
            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    if (a.IsConnected)
            //    {
            //        a.Close();
            //    }
            //}



            // int ii = 0;
            IMyArchivosAltContext archivosAltContext = new MyArchivosAltContextFactory().Create();
            List<SqPedimentosSirSaaiReturnModel> lista = archivosAltContext.SqPedimentosSirSaai("09/06/2018", "09/06/2018", 590, null, 1);
            //foreach (var element in lista)
            //{

                var sesion = Laserfiche.RepositoryAccess.Session.Create(server, database, user, password);
                try
                {
                    //conexionLF.Create((LFDatabase)baseDeDatosLF);
                    //Console.WriteLine("Se econtro referencia: " + element.Referencia);


                    IBuscadorDocumentos<Hinojosa.RepositorioDocumentos.DocumentoRepositorio> buscador = new Hinojosa.RepositorioDocumentos.Laserfiche.BuscadorDocumentosLaserficheRepositoryAccess(sesion);
                    //var s = buscador.BuscarDocumentosExpediente(new string[] { "Z1802672-00" }, null);
                    var s = buscador.BuscarDocumentosExpediente( lista.Select(s2 => s2.Referencia).ToArray() , null);

                    foreach (var mys in s)
                    {
                        Console.WriteLine("Se encontro archivo: " + mys.Nombre);
                    }


                    IExportadorDocumentos<DocumentoRepositorio> Exportador = new Hinojosa.RepositorioDocumentos.Laserfiche.ExportadorDocumentosLaserficheRepositoryAccess(sesion);
                    Exportador.Exportar(s, @"C:\DescargarDanfoss\", false, (d) => {
                        int dr = d.Ruta.IndexOf(d.Referencia);

                        return d.Ruta.Substring(dr, (d.Ruta.Length - dr )- (d.Ruta.Length - d.Ruta.LastIndexOf("\\")));
                        });

                    //foreach (var ss in s)
                    //{
                    //    Console.WriteLine(ss.Nombre);
                    //}


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                //if (!conexionLF.IsTerminated)
                //{
                //    conexionLF.Terminate();
                //}
                sesion.Close();
                }
            //}

            Console.ReadKey();
        }

        private static void NewMethod(Laserfiche.RepositoryAccess.Session a, Laserfiche.RepositoryAccess.EntryInfo entryInfor)
        {
            if (entryInfor.EntryType == Laserfiche.RepositoryAccess.EntryType.Folder)
            {
                var fol = Laserfiche.RepositoryAccess.Folder.GetFolderInfo(entryInfor.Id, a);

                var enls = new Laserfiche.RepositoryAccess.EntryListingSettings();
                var res = fol.OpenFolderListing(enls);

                for (int j = 1; j <= res.RowCount; j++)
                {

                    var info = res.GetEntryInfo(j);

                    if (info.EntryType == Laserfiche.RepositoryAccess.EntryType.Document)
                    {
                        var doci = Laserfiche.RepositoryAccess.Document.GetDocumentInfo(info.Id, a);



                        var de = new Laserfiche.DocumentServices.DocumentExporter();

                        if (doci.IsElectronicDocument)
                        {
                            de.ExportElecDoc(doci, "C:\\DescargarDanfoss\\" + info.Name + "." + doci.Extension);
                        }
                        else
                        {

                            var pr = new Laserfiche.RepositoryAccess.PageRange(1, doci.PageCount);
                            var ps = new Laserfiche.RepositoryAccess.PageSet(pr);

                            string nombre = doci.Name;
                            if (nombre.Contains("*"))
                            {
                                nombre = doci.TemplateName;
                            }

                            de.ExportPdf(doci, ps, Laserfiche.DocumentServices.PdfExportOptions.None, "C:\\DescargarDanfoss\\" + nombre + ".pdf");
                        }
                    }
                    else if (info.EntryType == Laserfiche.RepositoryAccess.EntryType.Folder)
                    {
                        NewMethod(a, info);
                    }
                }

            }
        }
    }
}

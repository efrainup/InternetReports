using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentProcessor100;
using LFSO100Lib;
using PdfExporter;
//using LFSO90Lib;
using Hinojosa.RepositorioDocumentos.Laserfiche;
using Hinojosa.RepositorioDocumentos;
using System.Data.SqlClient;

namespace DescargaLaserfichePrueba
{
    public class Something
    {
        public string prop1 { get; set; }
        public string prop2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var t = new ExportadorDocumentosLaserfiche<Something>();
            t.ExportarAsync(new List<DocumentoRepositorio>(), "", true).ConfigureAwait(false);
            SqlConnection con = new SqlConnection();
            
            Trace.Listeners.Add(new ConsoleTraceListener());
            
            //Conectamos a Laserfiche
            LFConnection conexionLF = new LFConnection();

            conexionLF.UserName = "ADMIN";
            conexionLF.Password = "A12345678";

            LFApplication aplicacionLF = new LFApplication();
            LFServer servidorLF = aplicacionLF.GetServerByName("ServerWA");
            LFDatabase baseDeDatosLF = servidorLF.GetDatabaseByName("DA-HINOJOSA");


            //Se obtienen las referencias que se encuentran en  
            

            try
            {
                Trace.WriteLine("Conectando a laserfiche");
                conexionLF.Create(baseDeDatosLF);
                //conexionLF.Connect(baseDeDatosLF);
                Trace.WriteLine("Conectado");


                //LFSearch busquedaLF = baseDeDatosLF.CreateSearch();
                //busquedaLF.Command = "{LF:LOOKIN=\"DA-HINOJOSA\\MANZANILLO\\2018\\GALVAPRIME, S.A. DE C.V. ID2281\\IMPO\\Z1801770-0A\", Subfolders=0} & {LF:Name=\"PEDIMENTO FORMATO ANTERIOR\", TYPE=\"D\"}";

                Trace.WriteLine("Inicia búsqueda");
                //busquedaLF.BeginSearch(true);
                Trace.WriteLine("Busqueda finalizada");

                //ILFCollection coleccionLF = busquedaLF.GetSearchHits();
                //14694366
                //var doc2 = baseDeDatosLF.GetEntryByID(14658218);
                var doc2 = baseDeDatosLF.GetEntryByID(14694366);
                LFDocument doc = doc2 as LFDocument;
                ILFEntry entry = doc2 as ILFEntry;

                var pe = new PdfExporter.PdfExporter();
                

                //doc.ElectFile.WriteStream.
                
               
                //long size = doc.ElectFileSize;
                //byte[] buffer = new byte[size];

                //doc.ElectFile.ReadStream.Open();

                
                //doc.ElectFile.ReadStream.ReadToBuffer(buffer);
                //doc.ElectFile.ReadStream.Close();

                //using (FileStream st = File.Create("something"))
                //{
                //    st.Write(buffer, 0, Convert.ToInt32(size));
                //    st.Flush();
                //}

                


                    //doc.ElectFile.WriteStream.
                    
                    var exportador = new DocumentExporter();
                exportador.SourceDocument = entry;
                //exportador.SourceDocument = doc.;

                //                exportador.
                //exportador.

                if (doc.ElectFile.MimeType == "application/pdf")
                {
                    try
                    {
                        doc.ElectFile.ReadStream.Open();
                        doc.ElectFile.ReadStream.Export(@"c:\users\analista.programador\downloads\lf\" + doc.Name + ".pdf");
                    }catch(Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        doc.ElectFile.ReadStream.Close();
                    }



                    var doc3 = (doc.ElectFile.Document as ILFDocument);
                    pe.ExportPagesToFile(doc3, @"c:\users\analista.programador\downloads\lf\" + doc.Name + ".pdf");
                }
                else {

                    //exportador.Format = Document_Format.DOCUMENT_FORMAT_EMBED_FAVOR_PDFA;
                    //exportador.ExportToFile(@"c:\users\analista.programador\downloads\lf\" + doc.Name + ".pdf");

                    exportador.Format = Document_Format.DOCUMENT_FORMAT_TIFF;
                    exportador.ExportToFile(@"c:\users\analista.programador\downloads\lf\" + doc.Name + "2");
                }


                //foreach (LFSearchHit laserficheHit in coleccionLF)
                //{

                //    LFDocument entradaLF = laserficheHit.Entry as LFDocument;
                //    //LFElectFile entradaLF2 = laserficheHit.Entry as LFElectFile;



                //    Console.WriteLine(entradaLF.ElectFile.Extension);

                //     //entradaLF.
                //     var exportador = new DocumentExporter();
                //    exportador.SourceDocument = entradaLF;

                //    Trace.WriteLine("Iniciando descarga de " + entradaLF.Name);
                //    exportador.Format = Document_Format.DOCUMENT_FORMAT_EMBED_FAVOR_PDFA;
                //    exportador.ExportToFile(@"c:\users\analista.programador\downloads\lf\" +  entradaLF.Name + ".pdf" );

                //    exportador.Format = Document_Format.DOCUMENT_FORMAT_TIFF;
                //    exportador.ExportToFile(@"c:\users\analista.programador\downloads\lf\" + entradaLF.Name + "2");

                //    exportador.Format = Document_Format.DOCUMENT_FORMAT_ELECTRONICFILE;
                //    exportador.ExportToFile(@"c:\users\analista.programador\downloads\lf\" + entradaLF.Name + "3");
                //}
                //using(FileStream file = File.Create(""))
                //{
                //    StreamWriter sw = new StreamWriter(file);
                //    sw.WriteLine("");
                //    sw.Flush();


                //}
            }
            catch (Exception exc)
            {
                Trace.TraceError(exc.Message);
            }
            finally
            {
                if (!conexionLF.IsTerminated)
                {
                    conexionLF.Terminate();
                    Trace.WriteLine("Desconectado");
                }
            }


            Console.ReadKey();
            
        }
    }
}

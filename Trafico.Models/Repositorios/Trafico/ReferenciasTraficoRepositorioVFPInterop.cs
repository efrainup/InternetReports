using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Hinojosa.RECOVFP.Entidades.Trafico;
using System.Globalization;
using System.Threading;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico
{
    public class ReferenciasTraficoRepositorioVFPInterop : AReportSourceXml<Stctrl21Entity>, IReferenciasTraficoRepositorio, IDisposable
    {
        protected recovfpinteroplibraries.Istctrl21 accesoStctrl21;
        public string TraficoPath { get; set; }


        public ReferenciasTraficoRepositorioVFPInterop(string TraficoDatabases)
        {
            TraficoPath = TraficoDatabases;
        }

        public Task<IEnumerable<Stctrl21Entity>> RecuperarPorFechaAltaAsync(DateTime fechaInicio, DateTime fechaFin)
        {
            return Task.Run(() => RecuperarPorFechaAlta(fechaInicio, fechaFin));
            ////Se traduce como objeto
            //var documentoXml = new XmlDocument();
            //documentoXml.LoadXml(resultadosXml);
            //XmlNodeList listaNodos = documentoXml.SelectNodes("/VFPData/resultadosstctrl21");

            //return await Task.Run(() =>
            //{
                
            //    return listaNodos.Cast<XmlNode>().Select(nodo => new Stctrl21Entity() {
            //        Refcia21 = nodo["refcia21"].InnerText,
            //        Frecep21 = Convert.ToDateTime(nodo["frecep21"].InnerText.Replace('T',' ')), //El dato proveniente del XML incluye una T para separar el tiempo
            //        Cvecli21 = nodo["cvecli21"].InnerText,
            //    });
            //});

        }
        public void Dispose()
        {
            if(accesoStctrl21 != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(accesoStctrl21);
            }
        }

        public IEnumerable<Stctrl21Entity> RecuperarPorFechaAlta(DateTime fechaInicio, DateTime fechaFin)
        {
            accesoStctrl21 = new recovfpinteroplibraries.Stctrl21();
            accesoStctrl21.SOURCE = TraficoPath;//@"\\175.50.5.3\dah3\sistemas\reco\trafico\data\";
            string resultadosXml = accesoStctrl21.RecuperaReferenciasPorFechaDeAlta(fechaInicio, fechaFin);


            return Fill(resultadosXml);
        }

        public Task<IEnumerable<Stctrl21Entity>> RecuperarPorFechaAltaClienteAsync(DateTime fechaInicio, DateTime fechaFin, string IdCliente)
        {
            return Task.Run(() => RecuperarPorFechaAltaCliente(fechaInicio, fechaFin,IdCliente));
        }

        public IEnumerable<Stctrl21Entity> RecuperarPorFechaAltaCliente(DateTime fechaInicio, DateTime fechaFin, string IdCliente)
        {
            accesoStctrl21 = new recovfpinteroplibraries.Stctrl21();
            accesoStctrl21.SOURCE = TraficoPath;// @"\\175.50.5.3\dah3\sistemas\reco\trafico\data\";
            string resultadosXml = accesoStctrl21.RecuperaReferenciasPorFechaDeAltaClienteStr(fechaInicio.ToString("yyyy-MM-dd"), fechaFin.ToString("yyyy-MM-dd"), IdCliente);


            return Fill(resultadosXml);
        }
    }
}

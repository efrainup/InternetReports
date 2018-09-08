using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using RECO.Models.Trafico;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico
{
    public class ReferenciasTraficoRepositorioVFPInterop : IReferenciasTraficoRepositorio, IDisposable
    {
        protected recovfpinteroplibraries.Istctrl21 accesoStctrl21;

        public async Task<IEnumerable<Stctrl21Entity>> RecuperarPorFechaAlta(DateTime fechaInicio, DateTime fechaFin)
        {
            accesoStctrl21 = new recovfpinteroplibraries.Stctrl21();
            accesoStctrl21.SOURCE = @"\\175.50.5.3\dah3\sistemas\reco\trafico\data\";
            string resultadosXml = accesoStctrl21.RecuperaReferenciasPorFechaDeAlta(fechaInicio, fechaFin);

            //Se traduce como objeto
            var documentoXml = new XmlDocument();
            documentoXml.LoadXml(resultadosXml);
            XmlNodeList listaNodos = documentoXml.SelectNodes("/VFPData/resultadosstcrl21");

            return await Task.Run(() =>
            {
                return listaNodos.Cast<XmlNode>().Select(nodo => new Stctrl21Entity() {
                    Refcia21 = nodo["Refcia21"].InnerText,
                    Frecep21 = Convert.ToDateTime(nodo["Frecep21"].InnerText),
                    Cvecli21 = nodo["Cvecli21"].InnerText,
                });
            });

        }
        public void Dispose()
        {
            if(accesoStctrl21 != null)
            {
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Hinojosa.RECOVFP.Entidades.Trafico;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico
{
    public class ReconocimientoDePreviosRepositorioVFPInterop : AReportSourceXml<Stprev26Entity>,IReconocimientoDePreviosRepositorio, IDisposable
    {
        recovfpinteroplibraries.Stprev26 Stprev26Provider;
        XmlSerializer ReferenciasSerializer;
        TextWriter ReferenciasTextWriterObject;
        StringBuilder ReferenciasStringBuilder;
        public string TraficoPath { get; set; }



        public ReconocimientoDePreviosRepositorioVFPInterop(string TraficoRuta)
        {

            TraficoPath = TraficoRuta;

            ReferenciasStringBuilder = new StringBuilder();

            Stprev26Provider = new recovfpinteroplibraries.Stprev26();
            ReferenciasTextWriterObject = new StringWriter(ReferenciasStringBuilder);
            ReferenciasSerializer = new XmlSerializer(typeof(string[]));
        }

        public void Dispose()
        {
            if (Stprev26Provider != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Stprev26Provider);
            }
        }

        public IEnumerable<Stprev26Entity> RecuperarReconocimientosDePrevioPorReferencias(IEnumerable<string> referencias)
        {
            
            ReferenciasSerializer.Serialize(ReferenciasTextWriterObject, referencias.ToArray());
            ReferenciasTextWriterObject.Flush();

            Stprev26Provider.SOURCE = TraficoPath;// @"\\175.50.5.3\dah3\sistemas\reco\trafico\data\";
            string resultadosXml = Stprev26Provider.RecuperarInformacionePreviosPorReferencias(ReferenciasStringBuilder.ToString());

            return Fill(resultadosXml);
        }

        public Task<IEnumerable<Stprev26Entity>> RecuperarReconocimientosDePrevioPorReferenciasAsync(IEnumerable<string> referencias)
        {
            return Task.Run(() => RecuperarReconocimientosDePrevioPorReferencias(referencias));
        }
    }
}

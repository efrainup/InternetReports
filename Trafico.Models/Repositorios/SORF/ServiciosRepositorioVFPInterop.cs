using Hinojosa.RECOVFP.Entidades.SORF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.SORF
{
    public class ServiciosRepositorioVFPInterop : AReportSourceXml<Srsoli01Entity>, IServiciosRepositorio
    {
        recovfpinteroplibraries.Srsoli01 Srsoli01Provider;
        XmlSerializer ReferenciasSerializer;
        TextWriter ReferenciasTextWriterObject;
        StringBuilder ReferenciasStringBuilder;
        public string TraficoPath { get; set; }
        public string SORFPath { get; set; }

        public ServiciosRepositorioVFPInterop(string TraficoRuta, string SORFRuta)
        {
            SORFPath = SORFRuta;
            TraficoPath = TraficoRuta;

            Srsoli01Provider = new recovfpinteroplibraries.Srsoli01();

            ReferenciasStringBuilder = new StringBuilder();
            ReferenciasTextWriterObject = new StringWriter(ReferenciasStringBuilder);
            ReferenciasSerializer = new XmlSerializer(typeof(Srsoli10Filter[]));
        }

        public IEnumerable<Srsoli01Entity> RecuperarListaDeServicios(IEnumerable<Srsoli10Filter> Filtro)
        {
            ReferenciasSerializer.Serialize(ReferenciasTextWriterObject, Filtro.ToArray());
            ReferenciasTextWriterObject.Flush();

            Srsoli01Provider.SOURCE = SORFPath; // @"\\175.50.5.3\dah3\sistemas\reco\sorf\emp003\data\";
            Srsoli01Provider.SOURCETRAFICO = TraficoPath; // @"\\175.50.5.3\dah3\sistemas\reco\trafico\data\";
            string resultadosXml = Srsoli01Provider.RecuperarServiciosPorReferencias(ReferenciasStringBuilder.ToString());

            return Fill(resultadosXml);
        }

        public Task<IEnumerable<Srsoli01Entity>> RecuperarListaDeServiciosAsync(IEnumerable<string> referencias)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Srsoli01Entity>> RecuperarListaDeServiciosAsync(IEnumerable<Srsoli10Filter> Filtro)
        {
            return Task.Run(() => RecuperarListaDeServicios(Filtro));
        }

        
        }


    }

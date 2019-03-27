using Hinojosa.RECOVFP.DataAccessLayer.Entidades.Scontrol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Scontrol
{
    public class LayoutDanfossRepositorio
    {
        public LayoutDanfossCollection Ejecutar(string clienteId, DateTime fechaInicio, DateTime fechaFin)
        {
            var ldanfoss = new layoutdanfoss.layoutdanfoss();

            string layoutDanfossStirng = ldanfoss.Ejecutar(clienteId, fechaInicio, fechaFin, "");

            //Liberamos memoria
            Marshal.ReleaseComObject(ldanfoss);

            XmlDocument xmlReader = new XmlDocument();
            xmlReader.LoadXml(layoutDanfossStirng);


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(LayoutDanfossCollection));

            LayoutDanfossCollection models = (LayoutDanfossCollection) xmlSerializer.Deserialize(new XmlNodeReader(xmlReader));
            return models;
        }
    }
}

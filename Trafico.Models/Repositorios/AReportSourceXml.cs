using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios
{
    public abstract class AReportSourceXml<T>
    {
        
        public AReportSourceXml()
        {

        }

        public IEnumerable<T> Fill(string xml)
        {
            List<T> resultado = new List<T>();

            //Se traduce como objeto
            var documentoXml = new XmlDocument();
            documentoXml.LoadXml(xml);

            string nombreEntidad = typeof(T).Name.ToLower();

            XmlNodeList listaNodos = documentoXml.SelectNodes($"/VFPData/{nombreEntidad}");

            foreach (XmlNode nodo in listaNodos)
            {
                T item = Activator.CreateInstance<T>();
                PropertyInfo[] propiedades = typeof(T).GetProperties();

                XmlNodeList listaPropiedadesObjetoXml = nodo.ChildNodes;

                foreach (XmlNode propiedadXml in listaPropiedadesObjetoXml)
                {
                    PropertyInfo propiedad = propiedades.FirstOrDefault(f => f.Name.Equals(propiedadXml.Name,StringComparison.InvariantCultureIgnoreCase));

                    if(propiedad != null)
                    {
                        //Verificar si se tiene que convertir a un nuevo tipo
                        object valor = null;

                        //Convertir al tipo de dato de la propiedad. En el caso que la propiedad sea nulable hay que buscar el tipo primitivo
                        if (propiedad.PropertyType.IsGenericType)
                        {
                            if (propiedad.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            {
                                Type underlyingTypeOfProperty = Nullable.GetUnderlyingType(propiedad.PropertyType);
                                string valorConvertir = propiedadXml.InnerText;
                                //Si el tipo al que se convierte es DateTime, hay que verificar que el dato esté en formato correcto
                                //En ocasiones vienen en formato yyyy-MM-ddThh:mm:ss donde T es constante. Para este caso se reemplaza la T por un espacio
                                if (underlyingTypeOfProperty == typeof(DateTime))
                                {
                                    valorConvertir = valorConvertir.Replace('T', ' ');
                                    if (!string.IsNullOrEmpty(valorConvertir)){
                                        valor = Convert.ChangeType(valorConvertir, underlyingTypeOfProperty);
                                    }
                                }
                                else
                                {
                                    valor = Convert.ChangeType(valorConvertir, underlyingTypeOfProperty);
                                }




                            }
                            else
                            {
                                //Verificar
                                valor = Convert.ChangeType(propiedadXml.InnerText, propiedad.PropertyType);
                            }
                        }
                        else
                        {
                            string valorConvertir = propiedadXml.InnerText;
                            //Si el tipo al que se convierte es DateTime, hay que verificar que el dato esté en formato correcto
                            //En ocasiones vienen en formato yyyy-MM-ddThh:mm:ss donde T es constante. Para este caso se reemplaza la T por un espacio
                            if (propiedad.PropertyType == typeof(DateTime))
                            {
                                valorConvertir = valorConvertir.Replace('T', ' ');
                                if (!string.IsNullOrEmpty(valorConvertir))
                                {
                                    valor = Convert.ChangeType(valorConvertir, propiedad.PropertyType);
                                }
                            }
                            else
                            {
                                valor = Convert.ChangeType(valorConvertir, propiedad.PropertyType);
                            }
                        }

                        propiedad.SetValue(item, valor);
                    }
                }

                resultado.Add(item);
            }


            return resultado;
        }
    }
}

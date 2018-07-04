using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reports.DAL
{
    public abstract class AReportSource<T>
    {
        public IEnumerable<T> Fill(DbDataReader reader)
        {
            List<T> enumerable = new List<T>();

            int countOfCoulumns = reader.GetSchemaTable().Columns.Count;
            //System.Data.DataColumn[] dataColumnArray = new System.Data.DataColumn[countOfCoulumns];
            //reader.GetSchemaTable().Columns.CopyTo(dataColumnArray, 0);

            while (reader.Read())
            {
                //Crear un objeto por cada registro devuelto por la consulta
                T instance = Activator.CreateInstance<T>();

                Type typeOfT = typeof(T);
                PropertyInfo[] properties = typeOfT.GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    string columnName = properties[i].Name;
                    string propertyName = properties[i].Name;

                    //Si la entidad tiene el custom attribute Column, lo toma como nombre, sino toma el nombre de la propiedad
                    Attribute columnNameAttribute = properties[i].GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute));
                    Type typeOfProperty = properties[i].GetType();

                    if (columnNameAttribute != null)
                    {
                        columnName = (columnNameAttribute as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute).Name;
                    }


                    //Si el nombre de la columna existe en los datos devueltos, mapear con la entidad
                    int ordinal;
                    try
                    {
                        ordinal = reader.GetOrdinal(columnName);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                    if (ordinal >= 0)
                    {
                        object value = reader.GetValue(ordinal);
                        object assignedValue = null;

                        //Si el valor es DbNull asigna un null si el objeto es nullable, sino, asigna un default.
                        if (!(DBNull.Value.Equals(value)))
                        {
                            //assignedValue = null;
                            if (properties[i].PropertyType.IsGenericType)
                            {
                                if(properties[i].PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                {
                                    Type underlyingTypeOfProperty = Nullable.GetUnderlyingType(properties[i].PropertyType);
                                    assignedValue = Convert.ChangeType(value, underlyingTypeOfProperty);
                                }
                                else
                                {
                                    //Verificar
                                    assignedValue = Convert.ChangeType(value, properties[i].PropertyType);
                                }
                            }
                            else
                            {
                                assignedValue = Convert.ChangeType(value, properties[i].PropertyType);
                            }
                            
                            
                            ////Se verifica si es nullable
                            //if (properties[i].PropertyType.IsGenericType)
                            //{
                            //    if(properties[i].PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            //    {
                            //        value = null;
                            //    }
                            //}



                        }
                        //else
                        //{
                        //    assignedValue = Convert.ChangeType(value, properties[i].PropertyType);
                        //}

                        //Asigna el alor a la entidad, pero la convierte al tipo de dato requerido
                        typeOfT.GetProperty(propertyName).SetValue(instance, assignedValue);
                    }
                }
                enumerable.Add(instance);

            }

            return enumerable;
        }
    }
}

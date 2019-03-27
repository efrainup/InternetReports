using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public interface IOperacionesRepositorio<T>
    {
        T CopiarDocumento(T Documento, string Ruta);
        T RenombrarArchivo(T Archivo, string Nombre);
        T AgregarPlantillaArchivo(T Archivo, string Plantilla);
        T ObtenerArchivoPorId(string Identificador);
        T ObtenerArchivoPorRuta(string Ruta);
        T CrearDirectorio(string Ruta);
        T CrearDirectorio(T DirectorioPadre,string NombreDirectorio);
        string[] RecuperarPlantillas();
    }
}

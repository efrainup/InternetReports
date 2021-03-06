﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public interface IBuscadorDocumentos<T> : IConectable where T : class
    {

        /// <summary>
        /// Busca documentos en el repositorio de archivos basado en una referencia y el nombre del documento
        /// </summary>
        /// <param name="busqueda">Referencias de las cuales se buscará el documento</param>
        /// <param name="nombreDocumento">Nombre del documento a buscar. Acepta wildcard, por ejemplo factura 174.pdf o factura*.pdf</param>
        /// <returns></returns>
        IEnumerable<T> BuscarDocumentosExpediente(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos);
        
        /// <summary>
        /// Busca asincronamente documentos en el repositorio de archivos basado en una referencia y el nombre del documento
        /// </summary>
        /// <param name="busqueda">Referencias de las cuales se buscará el documento</param>
        /// <param name="nombreDocumento">Nombre del documento a buscar. Acepta wildcard, por ejemplo factura 174.pdf o factura*.pdf</param>
        /// <returns></returns>
        Task<IEnumerable<T>> BuscarDocumentosExpedienteAsync(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos);

        /// <summary>
        /// Busca la carpeta contenedora
        /// </summary>
        /// <param name="Ruta">Ruta que se está buscando</param>
        /// <returns></returns>
        T BuscaCarpetaContenedora(string Ruta);
        /// <summary>
        /// Busca la carpeta de la referencia para la agencia aduanal
        /// </summary>
        /// <param name="Referencia"></param>
        /// <returns></returns>
        T BuscarCarpetaReferencia(string Referencia);
    }
}

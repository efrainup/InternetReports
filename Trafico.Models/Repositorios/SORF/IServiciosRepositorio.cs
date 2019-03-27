using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hinojosa.RECOVFP.Entidades.SORF;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.SORF
{
    public interface IServiciosRepositorio
    {
        Task<IEnumerable<Srsoli01Entity>> RecuperarListaDeServiciosAsync(IEnumerable<string> referencias);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ColeccionReferenciaPatente">Coleccion de tuplas con valores (Referencia, Patente)</param>
        /// <returns></returns>
        Task<IEnumerable<Srsoli01Entity>> RecuperarListaDeServiciosAsync(IEnumerable<Srsoli10Filter> Filtro);
        IEnumerable<Srsoli01Entity> RecuperarListaDeServicios(IEnumerable<Srsoli10Filter> Filtro);
    }
}
using Hinojosa.RECOVFP.Entidades.Trafico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico
{
    public interface IReconocimientoDePreviosRepositorio
    {
        /// <summary>
        /// Recupera los datos de los reconocimientos de previo hecho en el sistema de RECO Tráfico (VFP)
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Stprev26Entity>> RecuperarReconocimientosDePrevioPorReferenciasAsync(IEnumerable<string> referencias);
        IEnumerable<Stprev26Entity> RecuperarReconocimientosDePrevioPorReferencias(IEnumerable<string> referencias);
    }
}

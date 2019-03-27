using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Scontrol
{
    interface IReportes<T>
    {
        void Ejecutar(params object[] parametro);
        Task EjecutarAsync(params object[] parametro);
        IEnumerable<T> RecuperarLista();
        Task<IEnumerable<T>> RecuperarListaAsync();
    }
}

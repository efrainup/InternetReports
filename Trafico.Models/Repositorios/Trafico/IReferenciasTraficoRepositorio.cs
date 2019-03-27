using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hinojosa.RECOVFP.Entidades.Trafico;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico
{
    public interface IReferenciasTraficoRepositorio
    {
        Task<IEnumerable<Stctrl21Entity>> RecuperarPorFechaAltaAsync(DateTime fechaInicio, DateTime fechaFin);
        IEnumerable<Stctrl21Entity> RecuperarPorFechaAlta(DateTime fechaInicio, DateTime fechaFin);
        Task<IEnumerable<Stctrl21Entity>> RecuperarPorFechaAltaClienteAsync(DateTime fechaInicio, DateTime fechaFin, string IdCliente);
        IEnumerable<Stctrl21Entity> RecuperarPorFechaAltaCliente(DateTime fechaInicio, DateTime fechaFin, string IdCliente);
    }
}

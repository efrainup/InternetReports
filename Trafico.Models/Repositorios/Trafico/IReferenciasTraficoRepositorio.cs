using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RECO.Models.Trafico;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico
{
    public interface IReferenciasTraficoRepositorio
    {
        Task<IEnumerable<Stctrl21Entity>> RecuperarPorFechaAlta(DateTime fechaInicio, DateTime fechaFin);
    }
}

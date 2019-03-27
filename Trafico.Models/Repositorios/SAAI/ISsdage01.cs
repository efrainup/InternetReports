using Hinojosa.RECOVFP.DataAccessLayer.Entidades.SAAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.SAAI
{
    public interface ISsdage01
    {
        List<Ssdage01Entity> RecuperarPorReferencia(string referencia);
        List<Ssdage01Entity> RecuperarPorPedimentoAñoAduana(string pedimento, int año, int aduana);
        Task<List<Ssdage01Entity>> RecuperarPorReferenciaAsync(string referencia);
        Task<List<Ssdage01Entity>> RecuperarPorPedimentoAñoAduanaAsync(string pedimento, int año, int aduana);
    }
}

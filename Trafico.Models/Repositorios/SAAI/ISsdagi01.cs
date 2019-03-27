using Hinojosa.RECOVFP.DataAccessLayer.Entidades.SAAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.SAAI
{
    public interface ISsdagi01
    {
        List<Ssdagi01Entity> RecuperarPorReferencia(string referencia);
        List<Ssdagi01Entity> RecuperarPorPedimentoAñoAduana(string pedimento, int año, int aduana);
        Task<List<Ssdagi01Entity>> RecuperarPorReferenciaAsync(string referencia);
        Task<List<Ssdagi01Entity>> RecuperarPorPedimentoAñoAduanaAsync(string pedimento, int año, int aduana);
    }
}

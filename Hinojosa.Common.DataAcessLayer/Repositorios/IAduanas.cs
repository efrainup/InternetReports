using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.Common.DataAccessLayer.Repositorios
{
    public interface IAduanas : IOperacionesAccesoDatos<Entidades.AduanaSec>
    {
        IEnumerable<Entidades.AduanaSec> RecuperarAduanasHinojosa();
    }
}

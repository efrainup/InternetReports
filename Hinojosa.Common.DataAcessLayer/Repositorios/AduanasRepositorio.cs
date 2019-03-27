using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hinojosa.Common.DataAccessLayer.Entidades;

namespace Hinojosa.Common.DataAccessLayer.Repositorios
{
    public class AduanasRepositorio : IAduanas
    {
        SIREntidadesContext context;

        public AduanasRepositorio()
        {
            context = new SIREntidadesContext();
        }


        public AduanaSec Actualizar(AduanaSec entidad)
        {
            throw new NotImplementedException();
        }

        public Task<AduanaSec> ActualizarAsync(AduanaSec entidad)
        {
            throw new NotImplementedException();
        }

        public AduanaSec Crear(AduanaSec entidad)
        {
            throw new NotImplementedException();
        }

        public Task<AduanaSec> CrearAsync(AduanaSec entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(AduanaSec entidad)
        {
            throw new NotImplementedException();
        }

        public Task EliminarAsync(AduanaSec entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AduanaSec> Recuperar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AduanaSec> RecuperarAduanasHinojosa()
        {
            return context.Aduanasecs.Where(w => context.Sucursalpatenteaduanas.Any(a => a.IdAduSec06 == w.IdAduSec06)).ToList();
        }

        public Task<IEnumerable<AduanaSec>> RecuperarAsync()
        {
            throw new NotImplementedException();
        }

        public AduanaSec RecuperarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<AduanaSec> RecuperarPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

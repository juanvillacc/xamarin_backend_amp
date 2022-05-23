using AmpApi.API.Data;
using AmpApi.API.Domain;
using AmpApi.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmpApi.API.Repository
{
    public class SuscripcionRepository : GenericRepository<Suscripcion>, ISuscripcionRepository
    {
        public SuscripcionRepository(ApplicationDbContext contexto):base(contexto)  
        {

        }

        public IEnumerable<Suscripcion> ObtenerActivas()
        {
            return _contexto.Suscripciones.Where(x=> x.estado);
        }

        public async Task IngresarSuscripcion(Suscripcion entidad)
        {
            await Ingresar(entidad);
        }
        public void ActualizarSuscripcion(Suscripcion entidad)
        {
            Actualizar(entidad);
        }

        public async Task EliminarSuscripcion(int id)
        {
           await Eliminar(id);
        }

        public async Task<IEnumerable<Suscripcion>> Obtener()
        {
            return await ObtenerTodos();
        }
    }
}

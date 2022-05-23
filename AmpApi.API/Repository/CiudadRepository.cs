using AmpApi.API.Data;
using AmpApi.API.Domain;
using AmpApi.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmpApi.API.Repository
{
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudadRepository
    {
        public CiudadRepository(ApplicationDbContext contexto) : base(contexto)
        {

        }

        public async Task IngresarCiudad(Ciudad entidad)
        {
            await Ingresar(entidad);
        }
        public void ActualizarCiudad(Ciudad entidad)
        {
            Actualizar(entidad);
        }

        public async Task EliminarCiudad(int id)
        {
            await Eliminar(id);
        }

        public async Task<IEnumerable<Ciudad>> Obtener()
        {
             return await ObtenerTodos();
        }
    }
}

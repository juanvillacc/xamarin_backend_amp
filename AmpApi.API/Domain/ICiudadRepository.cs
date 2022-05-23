using AmpApi.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Domain
{
    public interface ICiudadRepository
    {
        Task<IEnumerable<Ciudad>> Obtener();
        Task IngresarCiudad(Ciudad entidad);
        void ActualizarCiudad(Ciudad entidad);
        Task EliminarCiudad(int id);
    }
}

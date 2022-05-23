using AmpApi.API.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Domain
{
    public interface ISuscripcionRepository
    {
        Task<IEnumerable<Suscripcion>> Obtener();
        IEnumerable<Suscripcion> ObtenerActivas();
        Task IngresarSuscripcion(Suscripcion entidad);
        void ActualizarSuscripcion(Suscripcion entidad);
        Task EliminarSuscripcion(int id);
    }
}

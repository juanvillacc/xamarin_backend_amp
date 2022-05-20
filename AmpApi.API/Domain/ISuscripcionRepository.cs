using AmpApi.API.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Domain
{
    public interface ISuscripcionRepository
    {
        IEnumerable<Suscripcion> ObtenerActivas();
        Task IngresarSuscripcion(Suscripcion entidad);
    }
}

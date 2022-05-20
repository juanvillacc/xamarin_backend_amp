using AmpApi.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Domain
{
    public interface IUnitOfWork
    {
        IEnumerable<Suscripcion> ObtenerSuscripciones();
        Task IngresarSuscripcion(Suscripcion dato);
    }
}

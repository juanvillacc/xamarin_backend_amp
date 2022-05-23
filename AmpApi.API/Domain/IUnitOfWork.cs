using AmpApi.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Domain
{
    public interface IUnitOfWork
    {
        IEnumerable<Suscripcion> ObtenerSuscripciones();
        Task IngresarSuscripcion(Suscripcion dato);

        void ActualizarSuscripcion(Suscripcion dato);

        Task EliminarSuscripcion(int id);
        Task<IEnumerable<Ciudad>> ObtenerCiudades();
        Task IngresarCiudad(Ciudad dato);
        void ActualizarCiudad(Ciudad dato);
        Task EliminarCiudad(int id);
    }
}

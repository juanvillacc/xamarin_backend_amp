using AmpApi.API.Domain;
using AmpApi.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class SuscripcionController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public SuscripcionController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("ObtenerSuscripciones")]
        public  IEnumerable<Suscripcion> ObtenerSuscripciones()
        {
            return  _unit.ObtenerSuscripciones();
        }

        [HttpPost]
        [Route("Ingresar")]
        public Task Ingresar(Suscripcion dato)
        {
            return _unit.IngresarSuscripcion(dato);
        }

        [HttpPut]
        [Route("Actualizar")]
        public void Actualizar(Suscripcion dato)
        {
             _unit.ActualizarSuscripcion(dato);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public Task Eliminar(int id)
        {
           return  _unit.EliminarSuscripcion(id);
        }
    }
}

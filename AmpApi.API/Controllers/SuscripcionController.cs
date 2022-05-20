using AmpApi.API.Domain;
using AmpApi.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Controllers
{
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
    }
}

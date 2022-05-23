using AmpApi.API.Domain;
using AmpApi.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmpApi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CiudadController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public CiudadController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("ObtenerCiudades")]
        public async Task<IEnumerable<Ciudad>> ObtenerCiudades()
        {
            return await _unit.ObtenerCiudades();
        }

        [HttpPost]
        [Route("Ingresar")]
        public Task Ingresar(Ciudad dato)
        {
            return _unit.IngresarCiudad(dato);
        }

        [HttpPut]
        [Route("Actualizar")]
        public void Actualizar(Ciudad dato)
        {
            _unit.ActualizarCiudad(dato);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public Task Eliminar(int id)
        {
            return _unit.EliminarCiudad(id);
        }
    }
}

using AmpApi.API.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AmpApi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeguridadController : ControllerBase
    {
        private IConfiguration _config;  

        public SeguridadController(IConfiguration config)
        {
            _config = config;
        }
        [HttpPost]
        [Route("ObtenerToken")]
        public string ObtenerToken(Usuario usuario)
        {
            var token = string.Empty;

            if (usuario.Login.Equals("Demo") && usuario.Clave.Equals("Pa$$word"))
            {
                var llaveEncripcion = _config.GetValue<string>("SecretKey");
                token = Security.ObtenerToken(llaveEncripcion);
            }

            return token;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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
                var key = Encoding.ASCII.GetBytes(llaveEncripcion);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim("Compania", "susalud") }),
                    Expires = DateTime.UtcNow.AddMinutes(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenCreated = tokenHandler.CreateToken(tokenDescriptor);
                token = tokenHandler.WriteToken(tokenCreated);
            }

            return token;
        }
    }
}

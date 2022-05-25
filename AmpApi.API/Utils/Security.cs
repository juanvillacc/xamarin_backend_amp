using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AmpApi.API.Utils
{
    public static class Security
    {
        public static string ObtenerToken(string llaveEncripcion)
        {

            var key = Encoding.ASCII.GetBytes(llaveEncripcion);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("Compania", "susalud") }),
                Expires = DateTime.UtcNow.AddMinutes(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenCreated = tokenHandler.CreateToken(tokenDescriptor);
            string token = tokenHandler.WriteToken(tokenCreated);
            return token;
        }
    }
}

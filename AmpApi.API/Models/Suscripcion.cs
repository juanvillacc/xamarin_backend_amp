using System.ComponentModel.DataAnnotations;

namespace AmpApi.API.Models
{
    public class Suscripcion
    {

        public int id_usuario_suscripcion { get; set; }

        public string documento { get; set; }
        public bool estado { get; set; }
    }
}

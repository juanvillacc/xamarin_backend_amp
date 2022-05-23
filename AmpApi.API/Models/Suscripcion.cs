using System.ComponentModel.DataAnnotations;

namespace AmpApi.API.Models
{
    public class Suscripcion
    {
        [Key]

        public int id_usuario_suscripcion { get; set; }

        public string documento { get; set; }
        public bool estado { get; set; }

        public string nombres { get; set; }

        public int id_ciudad { get; set; }
    }
}

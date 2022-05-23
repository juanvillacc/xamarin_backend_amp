using System.ComponentModel.DataAnnotations;

namespace AmpApi.API.Models
{
    public class Ciudad
    {
        [Key]

        public int id_ciudad { get; set; }

        public string nombres { get; set; }
    }
}

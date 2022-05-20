



using AmpApi.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AmpApi.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Suscripcion> Suscripciones { get; set; }
    }
}

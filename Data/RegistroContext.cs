using Microsoft.EntityFrameworkCore;
using PC03.Models;

namespace PC03.Data
{
    public class RegistroContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
    
}
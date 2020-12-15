using Microsoft.EntityFrameworkCore;
namespace PC03.Data
{
    public class RegistroContext
    {
         public class RegistroContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
    }
}
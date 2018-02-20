using Microsoft.EntityFrameworkCore;

namespace MvcPrueba.Models
{
    public class MvcCarContext : DbContext
    {
        public MvcCarContext (DbContextOptions<MvcCarContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPrueba.Models.Car> Car { get; set; }


        public DbSet<MvcPrueba.Models.Make> Make { get; set; }
    }
}
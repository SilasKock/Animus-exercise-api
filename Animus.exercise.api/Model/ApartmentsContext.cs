using Microsoft.EntityFrameworkCore;

namespace Animus.exercise.api.Model
{
    public class ApartmentsContext : DbContext
    {
        public ApartmentsContext(DbContextOptions<ApartmentsContext> options) : base(options)
        {
        }        

        public DbSet<ApartmentsDTO> Apartments { get; set; }
    }
}

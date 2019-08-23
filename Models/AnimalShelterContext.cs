using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=wildlife_park;");

        public AnimalShelterContext(DbContextOptions options) : base(options)
        {

        }
        public AnimalShelterContext()
        {

        }

    }
}
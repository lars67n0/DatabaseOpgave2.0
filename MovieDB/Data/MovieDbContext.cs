using Microsoft.EntityFrameworkCore;
using Obligatorisk_Database.Models;

namespace DatabaseOpgave2._0.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<TitleBasics> TitleBasics { get; set; }

        public DbSet<TitleCrew> TitleCrew { get; set; }

        public DbSet<NameBasics> NameBasics { get; set;}

    }
}

using Microsoft.EntityFrameworkCore;

namespace Phonebook
{
    public class AppContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public AppContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NI9RJP9\SQLEXPRESS01;Initial Catalog=Test;Integrated Security=True");
        }
    }
}
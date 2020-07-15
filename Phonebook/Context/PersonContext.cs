using Microsoft.EntityFrameworkCore;
using Phonebook.Entites;

namespace Phonebook.Context
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NI9RJP9\SQLEXPRESS01;Initial Catalog=Test;Integrated Security=True");
        }
    }
}
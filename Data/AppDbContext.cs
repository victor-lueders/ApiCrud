using ApiCrud.Pizzas;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    public class AppDbContext : DbContext
    {
        private DbSet<Pizza> Pizza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=.;Initial Catalog=Pizzaria;Integrated Security=True;MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

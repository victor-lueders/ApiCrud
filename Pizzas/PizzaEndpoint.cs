using ApiCrud.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Pizzas
{
    public static class PizzaEndpoint
    {
        public static void AddEndpointPizza(this WebApplication app)
        {
            var pizzaEndpoints = app.MapGroup("Pizzas");

            pizzaEndpoints.MapPost("", async (AddPizzaRequest request, AppDbContext context) =>
            {
                var newPizza = new Pizza(request.Sabor, request.Valor);

                await context.Pizza.AddAsync(newPizza);
                await context.SaveChangesAsync();
            });

            pizzaEndpoints.MapGet("", async (AppDbContext context) =>
            {
                var pizzas = await context.Pizza.ToListAsync();
                return pizzas;
            });
        }
    }
}

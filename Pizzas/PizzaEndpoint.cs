namespace ApiCrud.Pizzas
{
    public static class PizzaEndpoint
    {
        public static void AddEndpointPizza(this WebApplication app)
        {
            app.MapGet("Pizzas", () => new Pizza("queijo", 50));
        }
    }
}

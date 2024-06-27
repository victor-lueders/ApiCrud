using ApiCrud.Data;
using ApiCrud.Pedidos;
using ApiCrud.PizzaPedidos;

namespace ApiCrud.Pedidos
{
    public static class PedidoEndpoint
    {
        public static void AddEndpointPedido(this WebApplication app)
        {
            var pizzaEndpoints = app.MapGroup("Pedidos");

            pizzaEndpoints.MapPost("", async (AddPedidoRequest request, AppDbContext context) =>
            {
                var newPedido = new Pedido(request.Endereco, request.Nome);
                await context.Pedido.AddAsync(newPedido);

                foreach (var pizza in request.pizzas)
                {
                    var newPizzaPedido = new PizzaPedido(pizza.Sabor1, pizza.Sabor2);
                    newPizzaPedido.SetIdPedido(newPedido.Id);
                }

                await context.SaveChangesAsync();
            });
        }
    }
}

using ApiCrud.Data;
using ApiCrud.Pedidos;
using ApiCrud.PizzaPedidos;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Pedidos
{
    public static class PedidoEndpoint
    {
        public static void AddEndpointPedido(this WebApplication app)
        {
            var pedidoEndpoints = app.MapGroup("Pedidos");

            pedidoEndpoints.MapPost("", async (AddPedidoRequest request, AppDbContext context) =>
            {
                var newPedido = new Pedido(request.Endereco, request.Nome);
                await context.Pedido.AddAsync(newPedido);
                await context.SaveChangesAsync();

                foreach (var pizza in request.pizzas)
                {
                    var newPizzaPedido = new PizzaPedido(pizza.PizzaId1, pizza.PizzaId2);
                    newPizzaPedido.SetIdPedido(newPedido.Id);
                    await context.PizzaPedido.AddAsync(newPizzaPedido);
                }

                await context.SaveChangesAsync();
            });

            pedidoEndpoints.MapGet("", async (AppDbContext context) =>
            {
                var pedidos = await context.Pedido.ToListAsync();
                return pedidos;
            });
        }
    }
}

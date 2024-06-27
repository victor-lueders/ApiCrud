using ApiCrud.PizzaPedidos;

namespace ApiCrud.Pedidos
{
    public record AddPedidoRequest(PizzaPedido[] pizzas, string Endereco, string Nome);
}

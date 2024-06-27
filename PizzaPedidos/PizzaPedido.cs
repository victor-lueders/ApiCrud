using ApiCrud.Pedidos;
using ApiCrud.Pizzas;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCrud.PizzaPedidos
{
    public class PizzaPedido
    {
        public Guid Id { get; init; }

        [ForeignKey(nameof(Pizza))]
        public Guid PizzaId1 { get; set; }

        [ForeignKey(nameof(Pizza))]
        public Guid? PizzaId2 { get; set; } 

        [ForeignKey(nameof(Pedido))]
        private Guid PedidoId { get; set; }

        public void SetIdPedido(Guid idPedido)
        {
            PedidoId = idPedido;
        }

        public Guid GetIdPedido()
        {
            return PedidoId;
        }

        public PizzaPedido(Guid pizzaId1, Guid? pizzaId2)
        {
            PizzaId1 = pizzaId1;
            PizzaId2 = pizzaId2;
            Id = Guid.NewGuid();
        }
    }
}

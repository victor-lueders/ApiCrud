using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCrud.PizzaPedidos
{
    public class PizzaPedido
    {
        public Guid Id { get; init; }

        [ForeignKey("Pizza")]
        public Guid Sabor1 { get; set; }

        [ForeignKey("Pizza")]
        public Guid? Sabor2 { get; set; }

        [ForeignKey("Pedido")]
        private Guid IdPedido { get; set; }

        public void SetIdPedido(Guid idPedido)
        {
            IdPedido = idPedido;
        }

        public PizzaPedido(Guid sabor1, Guid? sabor2)
        {
            Sabor1 = sabor1;
            Sabor2 = sabor2;
            Id = Guid.NewGuid();
        }
    }
}

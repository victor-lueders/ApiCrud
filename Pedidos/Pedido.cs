using ApiCrud.PizzaPedidos;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCrud.Pedidos
{
    public class Pedido
    {
        public Guid Id { get; init; }
        public PizzaPedido[] Pizzas { get; init; }
        public string Endereco { get; set; }
        public string Nome { get; set; }

        public Pedido(string endereco, string nome)
        {
            Endereco = endereco;
            Nome = nome;
            Id = Guid.NewGuid();
        }
    }
}

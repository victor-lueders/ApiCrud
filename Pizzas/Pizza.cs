namespace ApiCrud.Pizzas
{
    public class Pizza
    {
        public Guid Id { get; init; }
        public string Sabor { get; set; }
        public double Valor { get; set; }

        public Pizza(string sabor, double valor)
        {
            Sabor = sabor;
            Valor = valor;
            Id = Guid.NewGuid();
        }
    }
}

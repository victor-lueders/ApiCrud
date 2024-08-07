﻿using ApiCrud.Pedidos;
using ApiCrud.PizzaPedidos;
using ApiCrud.Pizzas;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PizzaPedido> PizzaPedido { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=DESKTOP-EJE5VRC\\SQLEXPRESS;Initial Catalog=Pizzaria;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

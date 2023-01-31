using Microsoft.EntityFrameworkCore;
using tech_test_payment_MVC.Configuration;
using tech_test_payment_MVC.Models;

namespace tech_test_payment_api.Context
{
    public class OrganizadorVendaMvcContext : DbContext
    {
        //CRIANDO O CONSTRUTOR DbContext
        public OrganizadorVendaMvcContext(DbContextOptions<OrganizadorVendaMvcContext> options) : base(options)
        {

        }

        //CRIANDO AS TABELAS DbSet DO BANCO DE DADOS SqlServer
        public DbSet<Venda> Vendas { get; set; } 
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<ItensVendido> ItensVendidos { get; set; }

        //CONFIGURAÇÃO DIRECIONADA A CLASSE ItensVendido.cs, QUE NÃO VAI POSSUIR ID PRIMÁRIO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ItensVendidoConfiguration());
            //CRIADO UM ItensVendidoConfiguration.cs NA PASTA Configuration
                             //PARA ESPECIFICAR A Key DE DbSet<ItensVendido>
        }
    }
}
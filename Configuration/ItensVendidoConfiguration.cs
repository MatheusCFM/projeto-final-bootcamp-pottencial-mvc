using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tech_test_payment_MVC.Models;

namespace tech_test_payment_MVC.Configuration
{
    public class ItensVendidoConfiguration : IEntityTypeConfiguration<ItensVendido>
    {
        public void Configure(EntityTypeBuilder<ItensVendido> builder)
        {
            builder.HasKey(p => new { p.Nome });
            //DETERMINADA A CHAVE DE ORIGEM DA ÚNICA COLUNA DA TABELA ItensVendidos
        }        
    }
}
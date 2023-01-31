using System.ComponentModel.DataAnnotations.Schema;
using tech_test_payment_MVC.Models;

namespace tech_test_payment_MVC.Models
{
    //CRIANDO A CLASSE VENDA E SEUS DADOS DE ENTRADA
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public StatusVenda Status { get; set; }
        public ICollection<ItensVendido> ItemVendido { get; set; }
        // CRIANDO A LISTA DE ITENS VENDIDOS, PODENDO SER 1 OU MAIS.

        // VINCULANDO A CHAVE ESTRANGEIRA DO Vendedor
        [ForeignKey("Vendedor")]
        public int VendedorId { get; set; }
        // AQUI SERÁ MOSTRADO O MESMO VALOR DO Id DA CLASSE Vendedor.cs
        public Vendedor Vendedor { get; set; }
    }
}
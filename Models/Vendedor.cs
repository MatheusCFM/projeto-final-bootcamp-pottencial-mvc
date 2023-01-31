namespace tech_test_payment_MVC.Models
{
    //CRIANDO A CLASSE Vendedor.cs E SUAS PROPRIEDADES QUE FORMARÃO
    //AS COLUNAS DA TABELA Vendedores NO BANCO DE DADOS
    public class Vendedor
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        private List<Venda> Vendas { get; set; }
        //O VENDEDOR PODE RECEBER MAIS DE UMA VENDA
    }
}
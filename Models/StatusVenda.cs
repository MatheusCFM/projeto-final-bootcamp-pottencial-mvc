namespace tech_test_payment_MVC.Models
{
    //enum DETERMINA AS POSSÍVEIS ESCOLHAS PARA StatusVenda
    public enum StatusVenda
    {
        Aguardando_Pagamento,
        Pagamento_Aprovado,
        Enviado_Para_Transportadora,
        Entregue,
        Cancelada
    }
}
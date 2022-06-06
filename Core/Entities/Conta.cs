using Core.Entities.Enums;

namespace Core.Entities
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ContaBancaria Cc { get; set; }
        public string Categoria { get; set; }
        public FormasPagamento Pagamento { get; set; }
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime Emissao { get; set; }
        public bool Pago { get; set; }

    }
}

using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnun.Boleto; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnun.Deposito; }
        }

        public bool NãoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnun.NaoDefinido; }
        }

    }
}

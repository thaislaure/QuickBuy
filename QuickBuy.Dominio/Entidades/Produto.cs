namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMenagensValidacao();

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não foi informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descricao não foi informado ");
        }
    }
}

namespace APIDevSteamJau.Models
{
    public class CupomCarrinho
    {
        public Guid CupomCarrinhoId { get; set; } // Chave Primária
        public Guid? CarrinhoId { get; set; } // Chave Estrangeira
        public Carrinho? Carrinho { get; set; } // Propriedade de navegação para o carrinho
        public Guid? CupomId { get; set; } // Chave Estrangeira
        public Cupom? Cupom { get; set; } // Propriedade de navegação para o cupom
        public DateTime? DataAplicacao { get; set; } // Data em que o cupom foi aplicado
    }
}

namespace APIDevSteamJau.Models
{
    public class ItemCarrinho
    {
        public Guid ItemCarrinhoId { get; set; } // Chave Primária
        public Guid? CarrinhoId { get; set; } // Chave Estrangeira
        public Carrinho? Carrinho { get; set; } // Propriedade de navegação para o carrinho
        public Guid? JogoId { get; set; } // Chave Estrangeira
        public Jogo? Jogo { get; set; } // Propriedade de navegação para o jogo
        public int Quantidade { get; set; } // Quantidade do item no carrinho
        public decimal ValorUnitario { get; set; } // Valor unitário do item    
        public decimal ValorTotal { get; set; } // Valor total do item (Quantidade * ValorUnitario)
    }
}

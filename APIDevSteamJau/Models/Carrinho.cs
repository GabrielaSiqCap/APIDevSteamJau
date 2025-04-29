namespace APIDevSteamJau.Models
{
    public class Carrinho
    {
        public Guid CarrinhoId { get; set; } // Chave Primária
        public Guid? UsuarioId { get; set; } // Chave Estrangeira
        public Usuario? Usuario { get; set; } // Propriedade de navegação para o usuário
        public DateTime DataCriacao { get; set; } // Data de criação  do carrinho
        public bool? Finalizado { get; set; } // Ver se realmente o carrinho foi finalizado
        public DateTime? DataFinalizacao { get; set; } // Data de finalização do carrinho
        public decimal ValorTotal { get; set; } // Valor total do carrinho
        public object ItensCarrinhos { get; internal set; }
    }
}

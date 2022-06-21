using System;

namespace CpmPedidos.Domain
{
    public class PromocaoProduto: BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }

        // aqui estou fazendo a associação com a tabela Imagem (uma imagem tem N PromocaoProduto), e definindo minha FK como IdImagem
        public int IdImagem { get; set; }
        public virtual Imagem Imagem { get; set; }

        // aqui estou fazendo a associação com a tabela Produto (Muitos para Muitos - N imagem tem N Produtos), e definindo minha FK como IdProduto
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
    }
}

using System;

namespace CpmPedidos.Domain
{
    public class ProdutoPedido : BaseDomain
    {
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        // aqui estou fazendo a associação com a tabela Produto (um produto tem N ProdutoPedido), e definindo minha FK como IdProduto
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        // aqui estou fazendo a associação com a tabela Pedido (um pedido tem N ProdutoPedido), e definindo minha FK como IdPedido
        public int IdPedido { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CpmPedidos.Domain
{
    public class Produto: BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public virtual List<Imagem> Imagens { get; set; }
        public bool Ativo { get; set; }

        // aqui estou fazendo a associação com a tabela CategoriaProduto (uma CategoriaProduto tem N produtos), e definindo minha FK como IdCategoria
        public int IdCategoria { get; set; }
        public virtual CategoriaProduto Categoria { get; set; }
        public virtual List<PromocaoProduto> Promocoes { get; set; }

        public virtual List<Combo> Combos { get; set; }
    }
}

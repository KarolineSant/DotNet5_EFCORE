using System;
using System.Collections.Generic;

namespace CpmPedidos.Domain
{
    public class Pedido : BaseDomain
    {
        public string Numero { get; set; }
        public decimal ValorTotal { get; set; }
        public TimeSpan Entrega { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        // Relacionamento muitos para muitos com a tabela ProdutoPedido.
        public virtual List<ProdutoPedido> Produtos { get; set; }
    }

}
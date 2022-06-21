using System;
using System.Collections.Generic;

namespace CpmPedidos.Domain
{
    public class Cliente: BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        // aqui estou fazendo a associação com a tabela Endereco (um cliente tem um endereco), e definindo minha FK como IdEndereco
        public int IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }

        public bool Ativo { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
    }
}

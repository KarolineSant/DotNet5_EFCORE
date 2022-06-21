using CpmPedidos.Domain.Enums;
using System;

namespace CpmPedidos.Domain
{
    public class Endereco: BaseDomain
    {
        public TipoEnderecoEnum Tipo { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }


        // aqui estou fazendo a associação com a tabela Cidade (uma cidade tem muitos enderecos), e definindo minha FK como IdCidade
        public int IdCidade { get; set; }
        public Cidade Cidade { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}

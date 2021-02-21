using MeuControle.Modelos.Identificações;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuControle.Modelos.Estabelecimentos
{
    public abstract class Estabelecimento
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }

        public Estabelecimento(string nomeFantasia, string razaoSocial, string cnpj, Endereco endereco, Contato contato)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            Endereco = endereco;
            Contato = contato;
        }

    }
}

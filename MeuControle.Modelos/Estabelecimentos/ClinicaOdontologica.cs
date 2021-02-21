using MeuControle.Modelos.Identificações;
using MeuControle.Modelos.Pessoas.ModeloDentista;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuControle.Modelos.Estabelecimentos
{
    class ClinicaOdontologica : Estabelecimento
    {
        public Dentista ResponsalvelTecnico { get; set; }

        public ClinicaOdontologica(string nomeFantazia, string razaoSocial, string cnpj, Endereco endereco, Contato contato, Dentista responsavelTecnico) : base(nomeFantazia,razaoSocial,cnpj,endereco,contato)
        {
            ResponsalvelTecnico = responsavelTecnico;
        }
    }

    
}

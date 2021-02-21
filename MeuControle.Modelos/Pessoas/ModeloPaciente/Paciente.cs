using System;
using System.Collections.Generic;
using System.Text;
using MeuControle.Modelos.Pessoas.ModeloPaciente.Itens;
using MeuControle.Modelos.Identificações;

namespace MeuControle.Modelos.Pessoas.ModeloPaciente
{
    public class Paciente : Pessoa
    {
        public ProntuarioMedico ProntuarioMedico { get; set; }
        public Paciente(string nome, int idade, string cpf, ProntuarioMedico prontuarioMedico, Endereco endereco, Contato contato) : base(nome, idade, cpf, endereco, contato)
        {
            ProntuarioMedico = prontuarioMedico;
        }
        public Paciente()
        { 
        }
    }
}

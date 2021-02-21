using System;
using System.Collections.Generic;
using System.Text;
using MeuControle.Modelos.Identificações;
using MeuControle.Modelos.Pessoas.ModeloPaciente;
using MeuControle.Modelos.Pessoas.ModeloDentista.Itens;


namespace MeuControle.Modelos.Pessoas.ModeloDentista
{
    public class Dentista : Pessoa
    {
        public int CRO { get; set; }
        public Agenda Agenda { get; set; }
       
        public Dentista(string nome, int idade, string cpf, int cro, Endereco endereco, Contato contato, Agenda agenda) : base(nome, idade, cpf, endereco, contato)
        {
            CRO = cro;
            Agenda = agenda;

        }
    }
}

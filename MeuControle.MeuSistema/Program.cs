using System;
using System.Collections.Generic;
using MeuControle.Modelos.Identificações;
using MeuControle.Modelos.Pessoas.ModeloDentista;
using MeuControle.Modelos.Pessoas.ModeloDentista.Itens;
using MeuControle.Modelos.Pessoas.ModeloPaciente;

namespace MeuControle.MeuSistema
{
    class Program
    {
        static void Main(string[] args)
        {

            Endereco endereco = new Endereco("Parque Domingos Luis", 737, "02043-081", "São Paulo", "São Paulo");
            Contato contato = new Contato("11980450673", "amandabsouss19@gmail.com");
            Agenda agenda = new Agenda();
            List<Paciente> pacientes = new List<Paciente>();
            Dentista dentista = new Dentista("Amanda de Sousa Novais", 25, "40280324820", 123456,endereco,contato,agenda,pacientes);


            Console.WriteLine("Dados do dentista:");
            Console.WriteLine("Nome: " + dentista.Nome);
            Console.WriteLine("Idade: " + dentista.Idade);
            Console.WriteLine("CPF Nº: " + dentista.CPF);
            Console.WriteLine("CRO N°: " + dentista.CRO);

            Console.WriteLine("Dados de contato:");
            Console.WriteLine("Nº do Telefone: " + dentista.Contato.Telefone);
            Console.WriteLine("E-mail: " + dentista.Contato.Email);

            Console.WriteLine("Endereço do dentista:");
            Console.WriteLine("Rua: " + dentista.Endereco.Rua);
            Console.WriteLine("Numero: " + dentista.Endereco.Numero);
            Console.WriteLine("CEP: " + dentista.Endereco.CEP);
            Console.WriteLine("Cidade: " + dentista.Endereco.Cidade);
            Console.WriteLine("Estado: " + dentista.Endereco.Estado);
            Console.ReadLine();
        }
    }
}

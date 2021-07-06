using System;
using System.Collections.Generic;
using MeuControle.Modelos.Identificações;
using MeuControle.Modelos.Pessoas.ModeloDentista;
using MeuControle.Modelos.Pessoas.ModeloDentista.Itens;
using MeuControle.Modelos.Banco;

namespace MeuControle.MeuSistema
{
    class Program
    {
        static void Main(string[] args)
        {

            Endereco endereco = new Endereco("rua teste", 737, "99999-999", "São Paulo", "São Paulo");
            Contato contato = new Contato("11999999999", "aaa@aaa.com");
            Agenda agenda = new Agenda();
            Dentista dentista = new Dentista("Amanda teste", 25, "4444444444", 123456,endereco,contato,agenda);

            AcessoBanco ConnBanco = new AcessoBanco();
            ConnBanco.Dentista.InsertOne(dentista);
            Console.WriteLine("Dentista cadastrado com sucesso!");


            //Console.WriteLine("Dados do dentista:");
            //Console.WriteLine("Nome: " + dentista.Nome);
            //Console.WriteLine("Idade: " + dentista.Idade);
            //Console.WriteLine("CPF Nº: " + dentista.CPF);
            //Console.WriteLine("CRO N°: " + dentista.CRO);

            //Console.WriteLine("Dados de contato:");
            //Console.WriteLine("Nº do Telefone: " + dentista.Contato.Telefone);
            //Console.WriteLine("E-mail: " + dentista.Contato.Email);

            //Console.WriteLine("Endereço do dentista:");
            //Console.WriteLine("Rua: " + dentista.Endereco.Rua);
            //Console.WriteLine("Numero: " + dentista.Endereco.Numero);
            //Console.WriteLine("CEP: " + dentista.Endereco.CEP);
            //Console.WriteLine("Cidade: " + dentista.Endereco.Cidade);
            //Console.WriteLine("Estado: " + dentista.Endereco.Estado);
            //Console.ReadLine();
        }
    }
}

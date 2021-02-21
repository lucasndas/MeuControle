using MeuControle.Modelos.Identificações;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MeuControle.Modelos.Pessoas
{
    public abstract class Pessoa
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string CPF { get; private set; }
        public Endereco Endereco { get; private set; }
        public Contato Contato { get; set; }

        public Pessoa(string nome,int idade, string cpf, Endereco endereco, Contato contato) 
        {
            if (idade <= 0)
            {
                throw new ArgumentException("O argumento idade deve ser maior que 0.", nameof(idade));
            }

            Nome = nome;
            Idade = idade;
            CPF = cpf;
            Endereco = endereco;
            Contato = contato;
        }
        public Pessoa()
        { 
        }

    }
}

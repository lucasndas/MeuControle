using System;
using System.Collections.Generic;
using System.Text;

namespace MeuControle.Modelos.Identificações

{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }

        public Endereco(string rua, int numero, string cep, string cidade, string estado ) 
        {
            Rua = rua;
            Numero = numero;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
        }
    }
}

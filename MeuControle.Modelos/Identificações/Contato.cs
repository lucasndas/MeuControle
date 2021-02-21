using System;
using System.Collections.Generic;
using System.Text;

namespace MeuControle.Modelos.Identificações
{
    public class Contato
    {
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string telefone, string email) 
        {
            Telefone = telefone;
            Email = email;
        }
    }
}

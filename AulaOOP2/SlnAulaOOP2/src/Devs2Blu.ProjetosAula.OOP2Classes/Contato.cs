using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP2Classes
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public Int32 Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Contato() { }
            
        public Contato(String nome, String email, String telefone)
        {
            Nome = nome;
            Email = email;
            Tel = telefone;
        }

    }
}

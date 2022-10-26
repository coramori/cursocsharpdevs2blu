using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Models
{
    public class States
    {
        public Int32 Id { get; set; }

        public string State { get; set; }

        public string Description { get; set; }

        public States()
        {

        }

        public States(int id, string state, string description)
        {
            Id = id;
            State = state;
            Description = description;
        }
    }
}


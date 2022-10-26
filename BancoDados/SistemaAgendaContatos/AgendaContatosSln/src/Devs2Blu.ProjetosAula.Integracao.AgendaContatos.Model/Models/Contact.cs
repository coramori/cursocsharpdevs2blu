using Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Models
{
    public class Contact
    {
        public Int32 Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public Int32 Number { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public Contact()
        {

        }

        public Contact ( int id, string name, string phone, string email, string street, int number, string district, string city, string state)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Street = street;
            Number = number;
            District = district;
            City = city;    
            State = state;
        }
    }


}

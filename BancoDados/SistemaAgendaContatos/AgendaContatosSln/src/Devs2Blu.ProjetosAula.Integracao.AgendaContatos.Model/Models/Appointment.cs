using Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Models
{
    public class Appointment
    {
        public Int32 Id { get; set; }

        public Contact Contacts { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime InitialDate { get; set; }

        public DateTime FinalDate { get; set; }

        public StatusEnum Status { get; set; }

        public Appointment()
        {
            Contacts = new Contact();
        }

        public Appointment(int id, Contact contact, string title, string description, DateTime iniDate, DateTime finDate, StatusEnum status)
        {
            Id = id;
            Contacts = contact;
            Title = title;
            Description = description;
            InitialDate = iniDate;
            FinalDate = finDate;
            Status = status;  
        }
    }
}

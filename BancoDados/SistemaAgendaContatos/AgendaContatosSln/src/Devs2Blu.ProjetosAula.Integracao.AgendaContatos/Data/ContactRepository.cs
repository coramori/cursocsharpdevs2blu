using Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Data
{
    public class ContactRepository : BaseRepository
    {
        public ContactRepository() : base("contacts")
        {
        }

        public Contact FindById(int id)
        {
            Contact contact = new Contact();
            var r = base.FindById(id);
            while (r.Read())
            {
                contact = new Contact(r.GetInt32("id"), r.GetString("name"), r.GetString("phone"), r.GetString("email"), r.GetString("street"), r.GetInt32("number"), r.GetString("district"), r.GetString("city"), r.GetString("state"));
            }

            return contact;
        }
    }
}

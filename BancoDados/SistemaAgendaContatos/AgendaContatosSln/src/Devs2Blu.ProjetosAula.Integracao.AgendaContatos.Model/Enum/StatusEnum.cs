using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Enum
{
    public enum StatusEnum
    {
        [Description("Inactive")]
        I,
        [Description("Active")]
        A,
        [Description("Completed")]
        C,
        [Description("Rescheduled")]
        R
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Recepcionista : Pessoa
    {
        public int NumeroCracha { get; set; }

        public Recepcionista(string nome, string sobreNome)
        {
            this.Nome = nome;
            this.SobreNome = sobreNome;
        }

        public string AgendarConsulta()
        {
            return $"Consulta Agendada!";
        }
    }
}

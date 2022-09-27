﻿using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }

        public List<Medico> ListaMedicos { get; set; }

        public List<Recepcionista> ListaRecepcionistas { get; set; }

        public List<Fornecedor> ListaFornecedores { get; set; }


        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionistas();
            CargaFornecedores();
        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i,$"Paciente {i}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {
            Random rd = new Random();
            string[] especialidade = {"Neurologista", "Cardiologista", "Clínico Geral"};
            for (int i = 0; i < 4; i++)
            {
                Medico medico = new Medico(i, $"Medico {i}", $"{i}23{i}56{i}891{i}", rd.Next(1, 999), especialidade[rd.Next(0, especialidade.Length)]);
                ListaMedicos.Add(medico);
            }
        }

        public void CargaRecepcionistas()
        {
            Random rd = new Random();
            string[] setor = { "Neurologia", "Cardiologia", "Clínica Geral" };
            for (int i = 0; i < 5; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i}", $"{i}23{i}56{i}891{i}", setor[rd.Next(0, setor.Length)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }

        public void CargaFornecedores()
        {
            Random rd = new Random();
            string[] tipoFornecedor = { "Material Hospitalar", "Material de Limpeza"};
            for (int i = 0; i < 5; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i}", $"{i}23{i}56{i}891{i}", tipoFornecedor[rd.Next(0, tipoFornecedor.Length)]);
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
}

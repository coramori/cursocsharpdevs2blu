<<<<<<< HEAD
﻿using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
=======
﻿using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
<<<<<<< HEAD
    public class CadastroMedico : IMenuCadastro
=======
    internal class CadastroMedico
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
    {
        public CadastroMedico()
        {

        }

<<<<<<< HEAD
        private void ListarMedicosByCodeAndName()
        {
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"| {medico.CodigoMedico} - {medico.Nome} ");
            }
            Console.WriteLine("\n");
        }

        private void ListarMedicos()
=======
        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("------ Cadastro de Médicos ------");
                Console.WriteLine("------ 1- Lista de Médicos ------");
                Console.WriteLine("------ 2- Cadastro de Médicos -----");
                Console.WriteLine("------ 3- Alterar Médicos ------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("------------- 0- Sair ------------");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedicos();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarMedicos()
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
<<<<<<< HEAD
                Console.WriteLine("═════════════════════════════");
=======
                Console.WriteLine("-----------------");
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
                Console.WriteLine($"Médico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
<<<<<<< HEAD
                Console.WriteLine("═════════════════════════════");
=======
                Console.WriteLine("-----------------");
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
            }
            Console.ReadLine();
        }

<<<<<<< HEAD
        private void CadastrarMedicos(Medico novoMedico)
=======
        public void CadastrarMedico(Medico novoMedico)
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
        {
            Program.Mock.ListaMedicos.Add(novoMedico);
        }

<<<<<<< HEAD
        private void AlterarMedico(Medico medico)
        {
            var pact = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(pact);
            Program.Mock.ListaMedicos[index] = medico;
        }

        private void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Remove(medico);
        }

        #region FACADE

        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("╔══════ CADASTRO DE MÉDICOS ══════╗");
            Console.WriteLine("║ ═══════════════════════════════ ║");
            Console.WriteLine("║       1- Lista de Médicos       ║");
            Console.WriteLine("║       2- Cadastro de Médicos    ║");
            Console.WriteLine("║       3- Alterar Médicos        ║");
            Console.WriteLine("║       4- Excluir Médicos        ║");
            Console.WriteLine("║ ═══════════════════════════════ ║");
            Console.WriteLine("╚════════════ 0- SAIR ════════════╝");
            Console.Write("\nDigite o código da opção que deseja acessar: ");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarMedicos();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Medico medico = new Medico();

            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Informe o nome do médico: ");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do médico: ");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o CRM do médico: ");
            medico.CRM = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a especialidade do médico: ");
            medico.Especialidade = Console.ReadLine();

            CadastrarMedicos(medico);
        }

        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("| Digite o código do médico que deseja alterar: \n");

            ListarMedicosByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Médico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | CRM: {medico.CRM} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - CRM | 04 - Especialidade | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo CRM: ");
                        medico.CRM = Int32.Parse(Console.ReadLine());
                        break;
                    case "04":
                        Console.WriteLine("Informe uma nova especialidade: ");
                        medico.Especialidade = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado alterado com sucesso!");
                }
            } while (alterar);

            AlterarMedico(medico);
        }

        public void Excluir()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("| Lista de Médicos: ");
            ListarMedicosByCodeAndName();
            Console.WriteLine("Informe o código do médico que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);


            ExcluirMedico(medico);
        }
        #endregion
    }
}
=======
        public void AlterarMedico()
        {

        }

        public void ExcluirMedico()
        {

        }
    }
}
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d

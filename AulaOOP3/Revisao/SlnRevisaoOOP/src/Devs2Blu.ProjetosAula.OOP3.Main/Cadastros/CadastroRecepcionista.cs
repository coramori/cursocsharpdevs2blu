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
    public class CadastroRecepcionista : IMenuCadastro
=======
    internal class CadastroRecepcionista
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
    {
        public CadastroRecepcionista()
        {

        }

<<<<<<< HEAD
        private void ListarRecepcionistasByCodeAndName()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine($"| {recepcionista.CodigoRecepcionista} - {recepcionista.Nome} ");
            }
            Console.WriteLine("\n");
        }

        private void ListarRecepcionistas()
=======
        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("-------   Cadastro de Recepcionistas  -------");
                Console.WriteLine("------- 1- Lista de Recepcionistas    -------");
                Console.WriteLine("------- 2- Cadastro de Recepcionistas -------");
                Console.WriteLine("------- 3- Alterar Recepcionistas     -------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("------------------ 0- Sair ------------------");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionista();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarRecepcionista()
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
<<<<<<< HEAD
                Console.WriteLine("═════════════════════");
=======
                Console.WriteLine("-----------------");
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
<<<<<<< HEAD
                Console.WriteLine("═════════════════════");
=======
                Console.WriteLine("-----------------");
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
            }
            Console.ReadLine();
        }

<<<<<<< HEAD
        private void CadastrarRecepcionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }

        private void AlterarRecepcionista(Recepcionista recepcionista)
        {
            var pact = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(pact);
            Program.Mock.ListaRecepcionistas[index] = recepcionista;
        }

        private void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
        }

        #region FACADE

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("╔═══════ CADASTRO DE RECEPCIONISTA ═══════╗");
            Console.WriteLine("║ ═══════════════════════════════════════ ║");
            Console.WriteLine("║      1- Lista de Recepcionistas         ║");
            Console.WriteLine("║      2- Cadastro de Recepcionistas      ║");
            Console.WriteLine("║      3- Alterar Recepcionistas          ║");
            Console.WriteLine("║      4- Excluir Recepcionistas          ║");
            Console.WriteLine("║ ═══════════════════════════════════════ ║");
            Console.WriteLine("╚═══════════════ 0- SAIR ═════════════════╝");
            Console.Write("\nDigite o código da opção que deseja acessar: ");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarRecepcionistas();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Informe o nome do recepcionista: ");
            recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do recepcionista: ");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o setor do recepcionista: ");
            recepcionista.Setor = Console.ReadLine();

            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("| Digite o código do recepcionista que deseja alterar: \n");

            ListarRecepcionistasByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Recepcionista: {recepcionista.Codigo}/{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Setor | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor: ");
                        recepcionista.Setor = Console.ReadLine();
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

            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("| Lista de Recepcionistas: ");
            ListarRecepcionistasByCodeAndName();
            Console.WriteLine("Informe o código do recepcionista que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);


            ExcluirRecepcionista(recepcionista);
        }
        #endregion
=======
        public void CadastrarRecepcionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);

        }

        public void AlterarRecepcionista()
        {

        }

        public void ExcluirRecepcionista()
        {

        }
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
    }
}
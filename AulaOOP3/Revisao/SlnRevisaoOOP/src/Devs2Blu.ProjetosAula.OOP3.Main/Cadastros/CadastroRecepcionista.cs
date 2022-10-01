using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }

        private void ListarRecepcionistasByCodeAndName()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine($"| {recepcionista.CodigoRecepcionista} - {recepcionista.Nome} ");
            }
            Console.WriteLine("\n");
        }

        private void ListarRecepcionistas()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("-----------------");
            }
            Console.ReadLine();
        }

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
            Console.WriteLine("-------   Cadastro de Recepcionistas  -------");
            Console.WriteLine("------- 1- Lista de Recepcionistas    -------");
            Console.WriteLine("------- 2- Cadastro de Recepcionistas -------");
            Console.WriteLine("------- 3- Alterar Recepcionistas     -------");
            Console.WriteLine("------- 4- Excluir Recepcionistas     -------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------------------ 0- Sair ------------------");
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

            Console.WriteLine("Informe o recepcionista que deseja alterar: ");
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
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor: ");
                        recepcionista.Nome = Console.ReadLine();
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
    }
}
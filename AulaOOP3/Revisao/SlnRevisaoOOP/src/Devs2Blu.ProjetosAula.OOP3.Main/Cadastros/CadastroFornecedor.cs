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
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }

        private void ListarFornecedoresByCodeAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }

        private void ListarFornecedores()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("════════════════════════════════════════");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo do Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("════════════════════════════════════════");
            }
            Console.ReadLine();
        }

        private void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }

        private void AlterarFornecedor(Fornecedor fornecedor)
        {
            var pact = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(pact);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }

        private void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(fornecedor);
        }

        #region FACADE

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("╔═══════ CADASTRO DE FORNECEDORES ═══════╗");
            Console.WriteLine("║ ══════════════════════════════════════ ║");
            Console.WriteLine("║       1- Lista de Fornecedores         ║");
            Console.WriteLine("║       2- Cadastro de Fornecedores      ║");
            Console.WriteLine("║       3- Alterar Fornecedores          ║");
            Console.WriteLine("║       4- Excluir Fornecedores          ║");
            Console.WriteLine("║ ══════════════════════════════════════ ║");
            Console.WriteLine("╚═══════════════ 0- SAIR ════════════════╝");
            Console.Write("\nDigite o código da opção que deseja acessar: ");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarFornecedores();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Informe o nome do fornecedor: ");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do fornecedor: ");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o tipo do fornecedor: ");
            fornecedor.TipoFornecedor = Console.ReadLine();

            CadastrarFornecedor(fornecedor);
        }

        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("| Digite o código do fornecedor que deseja alterar: \n");

            ListarFornecedoresByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Fornecedor: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CPF: {fornecedor.CGCCPF} | Tipo de fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Tipo de Fornecedor | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo tipo de fornecedor: ");
                        fornecedor.TipoFornecedor = Console.ReadLine();
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

            AlterarFornecedor(fornecedor);
        }

        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("| Lista de Fornecedores: ");
            ListarFornecedoresByCodeAndName();
            Console.WriteLine("Informe o código do fornecedor que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);


            ExcluirFornecedor(fornecedor);
        }
        #endregion
    }
}


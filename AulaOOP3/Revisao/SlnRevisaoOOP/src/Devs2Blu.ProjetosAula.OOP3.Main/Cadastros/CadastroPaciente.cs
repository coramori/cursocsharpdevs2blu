using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {

        }

        private void ListarPacientesByCodeAndName()
        {
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine($"| {paciente.CodigoPaciente} - {paciente.Nome} ");
            }
            Console.WriteLine("\n");
        }

        private void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convênio: {paciente.Convenio}");
                Console.WriteLine("-----------------");
            }
            Console.ReadLine();
        }

        private void CadastrarPaciente(Paciente novoPaciente)
        {
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }

        private void AlterarPaciente(Paciente paciente)
        {
            var pact = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == paciente.CodigoPaciente);
            int index = Program.Mock.ListaPacientes.IndexOf(pact);
            Program.Mock.ListaPacientes[index] = paciente;
        }

        private void ExcluirPaciente(Paciente paciente)
        {
            Program.Mock.ListaPacientes.Remove(paciente);
        }

        #region FACADE

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("╔══════  CADASTRO DE PACIENTES  ════╗");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("║       1- Lista de Pacientes       ║");
            Console.WriteLine("║       2- Cadastro de Pacientes    ║");
            Console.WriteLine("║       3- Alterar Pacientes        ║");
            Console.WriteLine("║       4- Excluir Pacientes        ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("╚═════════════ 0- Sair ═════════════╝");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarPacientes();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Paciente paciente = new Paciente();

            Random rd = new Random();
            paciente.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            paciente.CodigoPaciente = Int32.Parse($"{paciente.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Informe o nome do paciente: ");
            paciente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do paciente: ");
            paciente.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o convênio do paciente: ");
            paciente.Convenio = Console.ReadLine();

            CadastrarPaciente(paciente);
        }

        public void Alterar()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPaciente;

            Console.WriteLine("Informe o paciente que deseja alterar: ");
            ListarPacientesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Paciente: {paciente.Codigo}/{paciente.CodigoPaciente} | Nome: {paciente.Nome} | CPF: {paciente.CGCCPF} | Convênio: {paciente.Convenio}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Convênio | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo convênio: ");
                        paciente.Nome = Console.ReadLine();
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

            AlterarPaciente(paciente);
        }

        public void Excluir()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPaciente;

            Console.WriteLine("| Lista de Pacientes: ");
            ListarPacientesByCodeAndName();
            Console.WriteLine("Informe o código do paciente que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);


            ExcluirPaciente(paciente);
        }

        #endregion


    }
}

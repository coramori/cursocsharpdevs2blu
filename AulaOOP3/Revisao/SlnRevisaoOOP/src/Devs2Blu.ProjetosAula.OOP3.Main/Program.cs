using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
<<<<<<< HEAD
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
=======
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks Mock { get; set; }

        static void Main(string[] args)
        {
<<<<<<< HEAD
            Int32 opcao = 0, opcaoMenuCadastros = 0;
            Mock = new Mocks();
            IMenuCadastro menuCadastros;

            do
            {
                if (opcaoMenuCadastros.Equals((int)MenuEnums.SAIR))
                {
                    Console.Clear();
                    Console.WriteLine("╔═══════ GERENCIAMENTO DE CLÍNICAS ═══════╗");
                    Console.WriteLine("║ ═══════════════════════════════════════ ║");
                    Console.WriteLine("║      10- Cadastro de Pacientes          ║");
                    Console.WriteLine("║      20- Cadastro de Médicos            ║");
                    Console.WriteLine("║      30- Cadastro de Recepcionistas     ║");
                    Console.WriteLine("║      40- Cadastro de Fornecedores       ║");
                    Console.WriteLine("║      50- Agenda                         ║");
                    Console.WriteLine("║      60- Prontuário                     ║");
                    Console.WriteLine("║      70- Financeiro                     ║");
                    Console.WriteLine("║ ═══════════════════════════════════════ ║");
                    Console.WriteLine("╚═══════════════  0 - SAIR  ══════════════╝");
                    Console.Write("\nDigite o código da opção que deseja acessar: ");
                    Int32.TryParse(Console.ReadLine(), out opcao);
                }
=======
            int opcao;
            Mock = new Mocks();

            do
            {
                Console.Clear();
                Console.WriteLine("---------- Selecione uma Opção: ----------");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("----- 10- Cadastro de Pacientes      -----");
                Console.WriteLine("----- 20- Cadastro de Médicos        -----");
                Console.WriteLine("----- 30- Cadastro de Recepcionistas -----");
                Console.WriteLine("----- 40- Cadastro de Fornecedores   -----");
                Console.WriteLine("----- 50- Agenda                     -----");
                Console.WriteLine("----- 60- Prontuário                 -----");
                Console.WriteLine("----- 70- Financeiro                 -----");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("---------------  0 - Sair  ---------------");
                Console.Write("\nDigite o código da opção que deseja acessar: ");
                Int32.TryParse(Console.ReadLine(), out opcao);
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
<<<<<<< HEAD
                        menuCadastros = new CadastroPaciente();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        menuCadastros = new CadastroMedico();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        menuCadastros = new CadastroRecepcionista();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        menuCadastros = new CadastroFornecedor();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    default:
                        menuCadastros = new CadastroPadrao();
                        opcaoMenuCadastros = (int)MenuEnums.SAIR;
                        break;
                }

                switch (opcaoMenuCadastros)
                {
                    case (int)MenuEnums.LISTAR:
                        menuCadastros.Listar();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        menuCadastros.Cadastrar();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        menuCadastros.Alterar();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        menuCadastros.Excluir();
                        break;
                    default:
                        opcaoMenuCadastros = 0;
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
=======
                        CadastroPaciente moduloCadastroPacientes = new CadastroPaciente();
                        moduloCadastroPacientes.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadastroMedico moduloCadastroMedicos = new CadastroMedico();
                        moduloCadastroMedicos.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        CadastroRecepcionista moduloCadastroRecepcionistas = new CadastroRecepcionista();
                        moduloCadastroRecepcionistas.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        CadastroFornecedor moduloCadastroFornecedores = new CadastroFornecedor();
                        moduloCadastroFornecedores.MenuCadastro();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }               
>>>>>>> 3a5c0bb9e7606b27853fd8f0bed891eeb129170d
    }
}

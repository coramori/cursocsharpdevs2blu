using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
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

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
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
    }
}

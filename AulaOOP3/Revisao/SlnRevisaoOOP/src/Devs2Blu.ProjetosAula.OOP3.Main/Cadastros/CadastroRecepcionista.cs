using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    internal class CadastroRecepcionista
    {
        public CadastroRecepcionista()
        {

        }

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
    }
}
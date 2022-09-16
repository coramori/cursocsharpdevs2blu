using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Devs2Blu.ProjetosAula.Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }


        static void SwitchExemplo1()
        {
            const string A21 = "A21";
            const string A22 = "A22";
            const string A23 = "A23";
            const string A24 = "A24";
            const string A35 = "A35";
            const string Z16 = "Z16";

            {
                /*
                 *  - "A21", "A22", "A23", "A24": Materiais
                    - "A35": Produtos Perecíveis
                    - "Z16": Produtos Químicos
                 */
                string codigo;

                Console.WriteLine("| Códigos Disponíveis: ");
                Console.WriteLine("| - A21");
                Console.WriteLine("| - A22");
                Console.WriteLine("| - A23");
                Console.WriteLine("| - A24");
                Console.WriteLine("| - A35");
                Console.WriteLine("| - Z16");
                Console.Write("\n| Digite um código para ver a descrição:");

                codigo = Console.ReadLine();

                switch (codigo.ToUpper())
                {
                    case A21:
                    case A22:
                    case A23:
                    case A24:
                        Console.WriteLine("A23: Materiais.");
                        break;
                    case A35:
                        Console.WriteLine("A35: Produtos Perecíveis.");
                        break;
                    case Z16:
                        Console.WriteLine("Z16: Produtos Químicos.");
                        break;

                    default:
                        Console.WriteLine("Produto Não Cadastrado.");
                        break;
                }
            }

        }


        static void Exercicio1()
        {
            string fruta;

            Console.WriteLine("| Catálogo de Frutas |");
            Console.WriteLine("|                    |");
            Console.WriteLine("|      - Maçã        |");
            Console.WriteLine("|      - Kiwi        |");
            Console.WriteLine("|    - Melancia      |");
            Console.WriteLine("|                    |");
            Console.Write("\n| Digite a fruta escolhida para verificar a disponibilidade: ");

            fruta = Console.ReadLine();

            switch (fruta.ToUpper()) // uppercase é o padrão
            {
                case "MAÇÃ":
                    Console.WriteLine("\n| Não vendemos esta fruta aqui.");
                    break;
                case "KIWI":
                    Console.WriteLine("\n| Estamos com escassez de kiwis.");
                    break;
                case "MELANCIA":
                    Console.WriteLine("\n| Aqui está, são 3 reais o quilo.");
                    break;
                default:
                    Console.WriteLine("\n| Opção não encontrada.");
                    break;
            }
        }


        static void Exercicio2()
        {
            // Um homem decidiu ir à uma revenda comprar um carro. Ele deseja comprar um carro hatch,
            // e a revenda possui, além de carros hatch, sedans, motocicletas e caminhonetes.
            // Utilizando uma estrutura switch/case, caso o comprador queira o hatch, retorne: "Compra efetuada com sucesso".
            // Nas outras opções , retorne : " Tem certeza que não prefere este modelo ?".
            // Caso seja especificado um modelo que não está disponível, retorne no console:
            // "Não trabalhamos com este tipo de automóvel aqui."

            const string HATCH = "HATCH";
            const string SEDAN = "SEDAN";
            const string MOTOCICLETA = "MOTOCICLETA";
            const string CAMINHONETE = "CAMINHONETE";

            string modeloAutomovel;
            Console.WriteLine("| AUTOMÓVEIS DISPONÍVEIS: |");
            Console.WriteLine("|        - Hatch          |");
            Console.WriteLine("|        - Sedan          |");
            Console.WriteLine("|     - Motocicleta       |");
            Console.WriteLine("|     - Caminhonete       |");
            Console.Write("\n| Digite o modelo do automóvel para efetuar a compra: ");

            modeloAutomovel = Console.ReadLine();

            switch (modeloAutomovel.ToUpper())
            {
                case HATCH:
                    Console.WriteLine("\n| Compra efetuada com sucesso.");
                    break;
                case SEDAN:
                case MOTOCICLETA:
                case CAMINHONETE:
                    Console.WriteLine("\n| Tem certeza que não prefere outro modelo?");
                    break;
                default:
                    Console.WriteLine("\n| Não trabalhamos com este tipo de automóvel aqui.");
                    break;
            }

        }

        /* EXERCICIO 5
         *  O usuário informa um número entre 1 e 20.
            O programa irá gerar números aleatórios entre 1 e 20.
            A pontuação do jogo é:
            Resultado 7 = 10 pts;
            Resultado 14 = 20 pts;
            Resultado 21 = 30 pts;
            Resultado entre 1 e 6 = 1 pt;
            Resultado entre 8 e 13 = 5 pts;
            Resultado entre 15 e 20 = 6 pts;
            Resultado acima de 20 = 0 pts;

            1- Utilize o case aninhado para os resultados de intervalos;
            2 - Acrescente o round do computador:
             a. O computador irá escolher um número entre 1-20 (informar o número escolhido);
             b. Gerar um número aleátório entre 1-20, para o computador.(Informar resultado)
         */

        // uso do i
        static void Exercicio52()
        {
            int valor, ptJogador, ptComputador;
            string aux;
            Random rand = new Random();
            int numeroAleatorio = rand.Next(1, 20);

            Console.WriteLine("Digite um numero para nosso jogo");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out valor);

            valor += numeroAleatorio;

            /* switch (valor)
            {
                case 1:
                case 2:
                case 3: 
                case 4: 
                case 5:
                case 6:
                    Console.WriteLine("Você ganhou 1 ponto");
                    ptJogador = 1;
                    break;
                case 7:
                    Console.WriteLine("Você ganhou 10 pontos");
                    ptJogador = 10;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Você ganhou 5 pontos");
                    ptJogador = 5;
                    break;
                case 14:
                    Console.WriteLine("Você ganhou 20 pontos");
                    ptJogador = 20;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Você ganhou 6 pontos");
                    ptJogador = 6;
                    break;
                case 21:
                    Console.WriteLine("Você ganhou 30 pontos");
                    ptJogador = 30;
                    break;
                default:
                    Console.WriteLine("Você passou dos 21 e perdeu!!");
                    ptJogador = 0;
                    break;
            }*/

            switch (valor)
            {
                case int i when (i <= 6):
                    Console.WriteLine("Você ganhou 1 ponto");
                    ptJogador = 1;
                    break;
                case 7:
                    Console.WriteLine("Você ganhou 10 pontos");
                    ptJogador = 10;
                    break;
                case int i when (i >= 8 && i <= 13):
                    Console.WriteLine("Você ganhou 5 pontos");
                    ptJogador = 5;
                    break;
                case 14:
                    Console.WriteLine("Você ganhou 20 pontos");
                    ptJogador = 20;
                    break;
                case int i when (i >= 15 && i <= 20):
                    Console.WriteLine("Você ganhou 6 pontos");
                    ptJogador = 6;
                    break;
                case 21:
                    Console.WriteLine("Você ganhou 30 pontos");
                    ptJogador = 30;
                    break;
                default:
                    Console.WriteLine("Você passou dos 21 e perdeu!!");
                    ptJogador = 0;
                    break;

            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Round do computador");
            int valorComputador = rand.Next(1, 21);

            valorComputador += numeroAleatorio;

            /*switch (valorComputador)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Computador ganhou 1 ponto");
                    ptComputador = 1;
                    break;
                case 7:
                    Console.WriteLine("Computador ganhou 10 pontos");
                    ptComputador = 10;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Computador ganhou 5 pontos");
                    ptComputador = 5;
                    break;
                case 14:
                    Console.WriteLine("Computador ganhou 20 pontos");
                    ptComputador = 20;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Computador ganhou 6 pontos");
                    ptComputador = 6;
                    break;
                case 21:
                    Console.WriteLine("Computador ganhou 30 pontos");
                    ptComputador = 30;
                    break;
                default:
                    Console.WriteLine("Computador passou dos 21 e perdeu!!");
                    ptComputador = 0;
                    break;
            }*/

            switch (valorComputador)
            {
                case int i when (i <= 7):
                    Console.WriteLine("Computador ganhou 1 ponto");
                    ptComputador = 1;
                    break;
                case 7:
                    Console.WriteLine("Computador ganhou 10 pontos");
                    ptComputador = 10;
                    break;
                case int i when (i >= 8 && i <= 13):
                    Console.WriteLine("Computador ganhou 5 pontos");
                    ptComputador = 5;
                    break;
                case 14:
                    Console.WriteLine("Computador ganhou 20 pontos");
                    ptComputador = 20;
                    break;
                case int i when (i >= 15 && i <= 20):
                    Console.WriteLine("Computador ganhou 6 pontos");
                    ptComputador = 6;
                    break;
                case 21:
                    Console.WriteLine("Computador ganhou 30 pontos");
                    ptComputador = 30;
                    break;
                default:
                    Console.WriteLine("Computador passou dos 21 e perdeu!!");
                    ptComputador = 0;
                    break;

            }

            Console.WriteLine("");
            if (ptJogador > ptComputador)
            {
                Console.WriteLine("Você venceu!!!!!");
            }
            else if (ptComputador > ptJogador)
            {
                Console.WriteLine("Computador Venceu");
            }
            else
            {
                Console.WriteLine("Os dois empataram");
            }

        }
    }
}


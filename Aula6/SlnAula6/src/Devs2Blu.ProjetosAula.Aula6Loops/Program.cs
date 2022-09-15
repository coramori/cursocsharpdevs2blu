using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula6Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 0;

            do
            {
                Console.WriteLine("\n\n|      OPÇÕES DISPONÍVEIS:      |");
                Console.WriteLine("|-------------------------------|");
                Console.WriteLine("|       1 - Exemplo 1           |");
                Console.WriteLine("|       2 - Exemplo 2           |");
                Console.WriteLine("|       3 - Exercicio 1         |");
                Console.WriteLine("|       4 - Exercicio 2         |");
                Console.WriteLine("|       5 - Exercicio 3         |");
                Console.WriteLine("|-------------------------------|");
                Console.Write("\n| Informe um dos códigos acima: ");

                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    case 3:
                        Exercicio1();
                        break;
                    case 4:
                        Exercicio2();
                        break;
                    case 5:
                        Exercicio3();
                        break;
                    default:
                        break;
                }

            } while (controle > 0);
        }



        static void Exemplo1()
        {
            int controle = 1;

            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
        }

        static void Exemplo2()
        {
            Console.WriteLine("Exemplo 2");
        }


        // EXERCÍCIO 1
        // Escreva um aplicativo que mostre todos os números ímpares de 1 até 100.
        /* usando for:
                        
            int number;
            Console.WriteLine("| Números ímpares de 1 a 100: ");

            for (number = 1; number <= 100; number++)
            {

                while (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
            */
        static void Exercicio1()
        {

            int number = 1;
            Console.WriteLine("| Números ímpares de 1 a 100: ");

            while (number <= 100)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine($"{number}");
                }
                number++;
            }
        }

        // EXERCÍCIO 2
        // Escreva um aplicativo que mostre todos os números pares de 1 até 100.
        static void Exercicio2()
        {

            int number = 1;
            Console.WriteLine("| Números pares de 1 a 100: ");

            while (number <= 100)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number}");
                }
                number++;
            }
        }


        // EXERCÍCIO 3
        // Escreva um aplicativo que recebe inteiro e mostra os números pares e ímpares (separados), de 1 até esse inteiro.
        static void Exercicio3()
        {
            Console.Clear();
            int limitNumber;
            int number = 1;

            Console.WriteLine("Informe um número limite: ");
            Int32.TryParse(Console.ReadLine(), out limitNumber);
            Console.WriteLine("Números ímpares: ");

            while (number <= limitNumber)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine($"{number}, ");
                }
                number++;

            }

            Console.WriteLine("Números pares: ");
            number = 1;
            while (number <= limitNumber)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number}, ");
                }
                number++;

            }
        }

        /* EXERCÍCIO 4
         Escreva um programa que pergunte ao usuário quantos alunos tem na sala dele.
         Em seguida, através de um laço while, pede ao usuário para que entre com as notas de todos os alunos da sala, um por vez.
         Por fim, o programa mostra a média, aritmética, da turma.

        - quantidade de alunos 
        - montante
        - qtd de alunos vai servir pro while rodar
        - inserir nota ou gerar randomicamente
        - média aritmética: valor total das notas e divide pela quantidade de alunos na sala
        */
        static void Exercicio4()
        {
            string numberOfStudents;
            Console.WriteLine("| Informe o número de alunos na turma: ");
            numberOfStudents = Console.ReadLine();
        }

    }
}

    
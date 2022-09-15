using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Devs2Blu.ProjetosAula.Revisao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _______________________ ");
            Console.WriteLine("| PROGRAMAS DISPONÍVEIS |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("|   1 - Exercício 1     |");
            Console.WriteLine("|   2 - Exercício 2     |");
            Console.WriteLine("|_______________________|\n");
            Console.Write("| Digite o código do programa: ");
            string codigoPrograma = Console.ReadLine();

            switch (codigoPrograma)
            {
                case "1":
                    Exercicio1();
                    break;
                case "2":
                    Exercicio2();
                    break;
                default:
                    break;
            }

           
        }

        
        // Exercício 1 - Lista While e Array
        // Escreva um aplicativo que mostre todos os números ímpares de 1 até 100.
        static void Exercicio1()
        {
            Console.Clear();

            int number = 1;
            Console.WriteLine("| Números ímpares de 1 a 100: ");

            while (number <= 100)
            {
                if (number % 2 != 0)
                {
                    Console.Write($"{number}, ");
                }
                number++;
            }
        }


        // Exercício 2
        // 4: Escreva um programa que pergunte ao usuário quantos alunos tem na sala dele.
        // Em seguida, através de um laço while, gere a note de todos os alunos da sala, um por vez.
        // Por fim, o programa mostra a média, aritmética, da turma.
        static void Exercicio2()
        {
            Console.Clear();

            int numeroAlunos, contador = 1, somaNotas = 0, mediaAlunos;
            Console.WriteLine(" Calculadora de Médias Escolares ");
            Console.WriteLine(" * * * * * * * * * * * * * * * * ");
            Console.Write("\n| Informe o número de alunos: ");
            string numeroAlunosSTR = Console.ReadLine();
            Int32.TryParse(numeroAlunosSTR, out numeroAlunos);

            Random rd = new Random();
            Console.Write($"\n| Nota dos alunos: ");

            while (contador <= numeroAlunos)
            {           
                int notas = rd.Next(5, 10);
                
                Console.Write($"{notas}, "); 
                contador++;
                somaNotas += notas;             
            }
            mediaAlunos = somaNotas / numeroAlunos;
            Console.WriteLine($"\n| Média da turma: {mediaAlunos}.\n");            
        }

    }
}

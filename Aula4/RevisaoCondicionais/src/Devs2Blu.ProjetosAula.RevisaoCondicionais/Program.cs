using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio4();
        }


        // EXERCÍCIO
        // Faça um programa que verifique se um número é impar. (fórmula n-n/2*2=0)
        static void Exercicio()
        {
            Console.WriteLine("| Exercício 1 : Verifica se um número é ímpar |");

            int number;
            Random rd = new Random();

            number = rd.Next(1, 100);

            if (!(number - number / 2 * 2 == 0))    //== é igual     //!= é diferente  //! é negação
            {
                Console.WriteLine($"O número {number} é ímpar!");
            } else {
                Console.WriteLine($"O número {number} é par!");
            }
        }


        /* EXERCÍCIO 1
         * Fazer um programa que retorne o nome de um produto a partir do código do mesmo.
         * Considere os seguintes códigos:
         * 001 - Arroz;
         * 002 - Feijão;
         * 003 - Farinha;
         * Para qualquer outro código indicar: Diversos.
         * */
        static void Exercicio1()
        {
            Console.Clear();

            Console.WriteLine("| *** PRODUTOS DISPONÍVEIS *** |");
            Console.WriteLine("| 001 - Arroz");
            Console.WriteLine("| 002 - Feijão");
            Console.WriteLine("| 003 - Farinha\n");

            Console.Write("| Escolha um produto: ");


            string product = Console.ReadLine();

            if (product.Equals("001"))
            {
                Console.WriteLine("Produto escolhido: Arroz.");
            } else if (product.Equals("002")) {
                Console.WriteLine("Produto escolhido: Feijão.");
            } else if (product.Equals("003"))
            {
                Console.WriteLine("Produto escolhido: Farinha.");
            } else
            {
                Console.WriteLine("Produto Diverso.");
            }


        }


        // EXERCÍCIOS LISTA IF-ELSE:


        /* EXERCÍCIO 2
         * Escreva um programa para ler o ano de nascimento de uma pessoa e escrever uma mensagem
         * que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que ela nasceu.)
         * Idade >= 16 anos
         * */
        static void Exercicio2() {

            int age, yearOfBirth;

            Console.Write("| Digite o ano do seu nascimento: ");
            string yearSTR = Console.ReadLine();
            Int32.TryParse(yearSTR, out yearOfBirth);

            age = DateTime.Now.Year - yearOfBirth; //Now é a data atual //Year é pra especificar apenas o ano

            if (age >= 16)
            {
                Console.WriteLine("\n| Você poderá votar esse ano!");
            } else
            {
                Console.WriteLine("\n| Por ter menos de 16 anos, você não poderá votar esse ano! ");
            }
        }


        /* EXERCÍCIO 3
         * Escreva um programa que verifique a validade de uma senha fornecida pelo usuário.
         * A senha válida é o número 1234. Devem ser impressas as seguitnes mensagens:
         * ACESSO PERMITIDO caso a senha seja válida.
         * ACESSO NEGADO caso a senha seja inválida.
         * */
        static void Exercicio3()
        {

            Console.Clear();
            string password;
            const string SYSTEM_PASSWORD = "1234";

            Console.Write("| Digite sua senha: ");
            password = Console.ReadLine();


            if (password.Equals(SYSTEM_PASSWORD))
            {
                Console.WriteLine("| ACESSO PERMITIDO");
            } else
            {
                Console.WriteLine("| ACESSO NEGADO");
            }

            /*
             * OPÇÃO COM TERNÁRIO
             * bool permission;
             * bool permission = password.Equals(SYSTEM_PASSWORD) ? true : false;
             * */
        }


        /* EXERCÍCIO 4
         * As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze.
         * Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.
         */
        static void Exercicio4()
        {
            Console.Clear();
            int appleQuantity;

            Console.Write("| Digite a quantidade de maçãs compradas: ");

            string appleQuantitySTR = Console.ReadLine();
            Int32.TryParse(appleQuantitySTR, out appleQuantity);

            if (appleQuantity < 12)
            {
                Console.WriteLine($"\n| O valor total da compra será de R${appleQuantity * 0.30}.");
            } if (appleQuantity >= 12)
            {

                Console.WriteLine($"\n| O valor total da compra será de R${appleQuantity * 0.25}.");
            }
        }

        
    }
}

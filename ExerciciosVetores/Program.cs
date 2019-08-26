using System;
using System.Globalization;

namespace ExerciciosVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented? 3");

            DadosPessoais[] array = new DadosPessoais[10];

            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= N; i++) {

                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                array[quarto] = new DadosPessoais(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (array[i] != null)
                {
                    Console.WriteLine(i + ":" + array[i]);
                }
            }
                   Console.ReadLine();
        }
    }
}

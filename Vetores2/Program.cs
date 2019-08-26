using System;
using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto[] vect = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price };

            }

            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / N;

            Console.WriteLine("AVERAGE PRINCE = " + avg.ToString("F2"), CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}

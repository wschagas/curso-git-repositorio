using System;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite M e N: ");
            string[] values = Console.ReadLine().Split(' ');
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);

            Console.WriteLine();
            Console.WriteLine("Matriz aleatoria");
            Console.WriteLine();
            int[,] mat = new int[n, n];

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {

                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Positção " + i + ", " + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda" + mat[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine(" Up: " + mat[i - 1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }

                        if (i< m - 1)
                        {
                            Console.Write("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

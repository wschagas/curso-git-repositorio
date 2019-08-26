using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunas do cruso A:");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso B possui quantos alunos?");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunas do cruso B:");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.Write("O curso C possui quantos alunos?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> Novo1 = new HashSet<int>();
            Novo1.UnionWith(A);
            Novo1.UnionWith(B);
            Novo1.UnionWith(C);
            Console.WriteLine("Total de Alunos: " + Novo1.Count);
            Console.ReadLine();
        }
    }
}


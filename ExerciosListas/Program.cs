using System;
using System.Collections.Generic;
using System.Globalization;


namespace ExerciosListas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many employees will be registered? 3");
            int N = int.Parse(Console.ReadLine());

            List<Salario> list = new List<Salario>(); //cria a lista


            for (int i = 1; i < N; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Salario( id, nome, salario ));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idFunc = int.Parse(Console.ReadLine());

            Salario fun = list.Find(x => x.ID == idFunc);
            if (fun != null){
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.porcentagem(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe! ");
            }
            {
                Console.WriteLine();
                Console.WriteLine("Lista atualizada de funcionários: ");
                foreach (Salario obj in list)
                Console.WriteLine(obj);
                {
                    Console.ReadLine();
                }
            }
        }
    }
}

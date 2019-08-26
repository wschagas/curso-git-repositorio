using System;
using System.Globalization;

namespace MostrarContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());


            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.Write("Entre um valor para depósito: ");
                double valordeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valordeposito);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.Write("Entre um valor para saque: ");
                double valorsaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(valorsaque);
                //conta.RealizarSaque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                conta = new ContaBancaria(numero, titular);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.Write("Entre um valor para depósito: ");
                conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.Write("Entre um valor para saque: ");
                conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine(conta);
            }
            Console.ReadLine();
        }
    }
}

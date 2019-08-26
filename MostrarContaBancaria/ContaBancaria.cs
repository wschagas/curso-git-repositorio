using System.Globalization;

namespace MostrarContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        //public double ValorDeposito { get; set; }
        //public double ValorSaque { get; set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double valordeposito)
        {
            Saldo += valordeposito;
        }

        public void Saque(double valorsaque)
        {
            Saldo = (Saldo - valorsaque) - 5;
        }

        public override string ToString()
        {
            return "Dados da conta: "
                + "Conta " + Numero
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

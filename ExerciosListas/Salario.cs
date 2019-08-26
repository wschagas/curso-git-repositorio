using System;
using System.Globalization;

namespace ExerciosListas
{
    class Salario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salar { get; set; }

        public Salario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salar = salario;
        }

        public void porcentagem(double porcentagem)
        {
            Salar += Salar * porcentagem / 100;
        }

        public override string ToString()
        {
            return (ID + ", " + Nome + ", " + Salar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

namespace ExerciciosVetores
{
    class DadosPessoais
    {
        public string Nome { get; set; }
        public string Email { get; set; }



        public DadosPessoais(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}

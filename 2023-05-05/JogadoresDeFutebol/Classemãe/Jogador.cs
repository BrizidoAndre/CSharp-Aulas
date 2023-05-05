namespace JogadoresDeFutebol
{
    abstract class Jogador
    {
        public string Nome { get; private set; }
        public int DataDeNascimento { get; private set; }
        public int Idade { get; private set; }
        public string Nacionalidade { get; private set; }
        public float Altura { get; private set; }
        public float Peso { get; private set; }
        public void CadastrarJogador()
        {
            Console.WriteLine($"Insira as informações do Jogador");
            Console.WriteLine($"");
            Console.WriteLine($"Qual o nome do Jogador?");
            Nome = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"Qual o ano em que ele nasceu?");
            DataDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine($"");
            Console.WriteLine($"Qual sua nacionalidade?");
            Nacionalidade = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"Qual sua altura?");
            Altura = (float)Math.Round(double.Parse(Console.ReadLine()),2);




        }
        public int CalcularIdade()
        {
            Idade = DataDeNascimento - DateTime.Now.Year;
            return Idade;
        }
        public abstract int CalcularAposentadoria();
    }
}
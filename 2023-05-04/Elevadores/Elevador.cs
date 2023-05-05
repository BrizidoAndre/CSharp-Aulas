namespace Elevadores
{
    public class Elevador
    {
        public int AndarAtual { get; private set; } = 0;
        public int TotalAndares { get; private set; }
        public int PessoasPresentes { get; private set; } = 0;
        public float CapacidadePeso { get; private set; }
        private void LimparTela()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void Inicializa()
        {
            Console.WriteLine(@$"
Qual a quantidade de pessoas que o elevador suporta?");
            CapacidadePeso = int.Parse(Console.ReadLine());
            Console.WriteLine(@$"
Qual o total de andares do predio?");
            TotalAndares = int.Parse(Console.ReadLine());
            Console.WriteLine(@$"
Informações obtidas -
Total de Pessoas: {CapacidadePeso}
Total de Andares: {TotalAndares}");
            LimparTela();
        }
        public void Entrar()
        {
            if (PessoasPresentes == CapacidadePeso)
            {
                Console.WriteLine($"O elevador está na capacidade máxima");
                LimparTela();
            }
            else
            {
                Console.WriteLine($"Entrando uma pessoa no elevador");
                PessoasPresentes += 1;
                LimparTela();
            }
        }
        public void Sair()
        {
            if (PessoasPresentes <= 0)
            {
                Console.WriteLine($"Não há ninguém para sair!!!");
                LimparTela();
            }
            else
            {
                Console.WriteLine($"Saindo um indivíduo no elevador!");
                PessoasPresentes -= 1;
                LimparTela();
            }
        }
        public void Subir()
        {
            if (AndarAtual == TotalAndares)
            {
                Console.WriteLine($"O elevador já está no último andar.");
                LimparTela();
            }
            else
            {
                Console.WriteLine($"Elevador subindo um andar");
                AndarAtual += 1;
                LimparTela();
            }
        }
        public void Descer()
        {
            if (AndarAtual <= 0)
            {
                Console.WriteLine($"O elevador já está no térreo.");
                LimparTela();
            }
            else
            {
                Console.WriteLine($"Elevador descendo um andar");
                AndarAtual -= 1;
                LimparTela();
            }
        }
        public void Mostrar()
        {
            Console.WriteLine(@$"
Andar atual: {AndarAtual}
Quantidade de pessoas no elevador: {PessoasPresentes}

Total de Pessoas: {CapacidadePeso}
Total de Andares: {TotalAndares}");
            Thread.Sleep(2000);
            LimparTela();
        }
    }
}
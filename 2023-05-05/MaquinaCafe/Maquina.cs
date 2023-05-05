namespace MaquinaCafe
{
    public class Maquina
    {
        public int AcucarDisponivel { get; private set; } = 200;

        private void LimparTela()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void FazerCafe()
        {
            if (AcucarDisponivel < 10)
            {
                Console.WriteLine($"Não há açucar suficiente na máquina. Fazendo um café sem açucar");
            }
            else
            {
                Console.WriteLine($"Fazendo café com açucar padrão (10 gramas).");
                AcucarDisponivel -= 10;
            }
            LimparTela();
        }
        public void FazerCafe(int acucar)
        {
            if (AcucarDisponivel == 0)
            {
                Console.WriteLine($"Não há açucar na máquina. Fazendo um café sem açucar");
            }
            else if (AcucarDisponivel - acucar < 0)
            {
                Console.WriteLine($"Não temos a quantidade de açucar selecionada. Atualmente {AcucarDisponivel} gramas de açucar sobrando.");
            }
            else if (AcucarDisponivel - acucar >= 0)
            {
                Console.WriteLine($"Fazendo café com {acucar} gramas de açúcar");
                AcucarDisponivel -= acucar;
            }
            LimparTela();
        }
        public void ReporAcucar()
        {
            Console.WriteLine($"Repondo açúcar");
            AcucarDisponivel = 200;
            LimparTela();
        }
    }
}
namespace Celular
{
    public class Celular
    {
        // PROPRIEDADES
        public string cor = "Preto";
        public string modelo = "Samsung Galaxy J5";
        public string tamanho = "720 x 1280 pixels";
        public string memoria = "16 Gigabytes";
        public bool ligado = false;
        int chamadas;
        // METODOS
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
        public void FazerLigacao()
        {
            Console.Write($"Fazendo Ligacao");
            for (var i = 0; i < 4; i++)
            {
                Console.Write($".");
                Thread.Sleep(1000);
            }
            Console.WriteLine($".");
            Console.WriteLine($"Alo?");
            Console.ReadLine();
            Console.WriteLine($"Alou, quem fala?");
            Console.ReadLine();
            if (chamadas == 0)
            {    
            Console.WriteLine($"Mas que droga");
            }
            else
            {
                Console.WriteLine($"Mas que droga, ja e a {chamadas} vez");
            }
            
        }
        public void EnviarMensagem()
        {

        }
        public void MostrarInformacoes()
        {
            Console.WriteLine(cor);
            Console.WriteLine(modelo);
            Console.WriteLine(tamanho);
            Console.WriteLine(memoria);
        }
    }
}
namespace _2023_04_20
{
    public class Personagem
    {
        public string nome = "Tony Stark";
        public int idade = 35;
        public string armadura = "Bleeding Edge";
        public string ia = "Jarvis";

        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
        }
        public string Defender()
        {
            return "O personagem defende!";
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem regenera a armadura");
        }
        public string Aparar()
        {
            return "O personagem Apara o ataque!";
        }
    }
}
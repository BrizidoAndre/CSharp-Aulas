namespace Projeto.Classes
{
    public class Login
    {
        static void CorAmarela(string texto)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(texto);
            Console.ResetColor();
            
        }
        static void CorVerde(string texto)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ResetColor();
            
        }
        public bool Logado { get; private set; }
        public Login(bool _logado)
        {
            Logado = _logado;
        }
        public string Logar(Usuario _usuario)
        {
            
        }
        public string Deslogar(Usuario _usuario)
        {

        }
    }
}
namespace CambioMoeda
{
    public class ConversorMoeda
    {

        public static float valorDolar = 5.01F;
        // A propriedade em static para o método captar o valor
        public static float ReaisDolar()
        {
            return InicializarValor() / valorDolar ;
        }
        public static float DolarReais()
        {
            return InicializarValor() * valorDolar;
        }
        public static float DolarEuro()
        {
            return InicializarValor() * 1.09F;
        }
        public static float InicializarValor()
        {
            Console.WriteLine($"Por favor insira o valor a ser convertido.");
            float valor = float.Parse(Console.ReadLine());
            return valor;
        }
    }
}
namespace Temperatura
{
    public static class ConversorTemperatura
    {
        // método estático para converter temperatura de celsius para fahrenheit
        public static double CelsiusParaFahrenheit(float celsius)
        {
            float fahrenheit = (celsius * 1.8F) + 32;
            return fahrenheit;
        }
        public static float FahrenheitParaCelsius(float fahrenheit)
        {
            float celsius = (fahrenheit - 32)/1.8F;
            return celsius;
        }
        public static void RColor()
        {
            Console.ResetColor();
        }
    }
}
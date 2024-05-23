namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var celcius = TempConverter.FahrenheitToCelcius(55);
            Console.WriteLine($" 55 Fahrenheit is {celcius} degrees celcius.");

            var fahrenheit = TempConverter.CelciusToFahrenheit(10);
            Console.WriteLine($"10 celcius is {fahrenheit} degrees fahrenheit.");

        }
    }
}

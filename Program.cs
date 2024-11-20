namespace Opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grader();
        }

        static void Grader() 
        {
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature in Fahrenheit is: " + Fahrenheit);
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius is: " + Celsius);
            Console.ReadLine();
        }
    }
}

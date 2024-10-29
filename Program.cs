namespace Opgave_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bmicalc();
        }

        static void bmicalc()
        {
            Console.WriteLine("Enter your weigth in KG: ");
            double weigth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in Meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your BMI is : {0}", weigth / (height * height));

        }
    }
}

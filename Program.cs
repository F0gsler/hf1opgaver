namespace Opgave_11
{
    internal class Program
    {
        const double momsPrice = 1.25;

        static void Main(string[] args)
        {
            price();
        }

        static void price()
        {
            Console.WriteLine("Enter your price that you need moms on");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your price with moms is: {0}", momsPrice * price);
        }
    }
}

namespace Opgave_15
{
    internal class Program
    {

        static double tal1 = Convert.ToDouble(Console.ReadLine());
        static double tal2 = Convert.ToDouble(Console.ReadLine());
        static double tal3 = Convert.ToDouble(Console.ReadLine());

        static double[] numbers = { tal1, tal2, tal3 };

        static void Main(string[] args)
        {
            calc();
        }

        static void calc()
        {
            Console.WriteLine("Enter your numbers");
            Array.Sort(numbers);
            Console.WriteLine("Numbers in order: {0} {1} {2} ", numbers[0], numbers[1], numbers[2]);
        }

    }
}
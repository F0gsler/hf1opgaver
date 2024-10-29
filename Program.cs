namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            tal();
        }

        public static void tal()
        {
        int tal1 = Convert.ToInt32(Console.ReadLine());
        int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Added: {0}",tal1 + tal2);
            Console.WriteLine("Subtractet: {0}", tal1 - tal2);
            Console.WriteLine("Multiplyed: {0}", tal1 * tal2);
            Console.WriteLine("Divived: {0}", tal1 / tal2);

        }
    }
}

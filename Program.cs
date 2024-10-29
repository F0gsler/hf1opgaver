namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

        static void Welcome()
        {
            Console.WriteLine("Enter your name!");
            string? name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello Welcome to this opgave {0}!", name);
        }

    }
}

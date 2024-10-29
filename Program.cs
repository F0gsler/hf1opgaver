namespace Opgaver_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc();
        }

        static void Calc()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Calculater!");
                Console.WriteLine("Enter your Numbers");
                double tal1 = Convert.ToDouble(Console.ReadLine());
                double tal2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A for addition");
                Console.WriteLine("S for subtract");
                Console.WriteLine("M for multiplyer");
                Console.WriteLine("D for Divied");
                Console.ResetColor();
                Console.WriteLine("");

                switch (Console.ReadLine())
                {
                    case "A":
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Added: {0}", tal1 + tal2);
                        break;
                    case "S":
                    case "s":
                        Console.Clear();
                        Console.WriteLine("Subtractet: {0}", tal1 - tal2);
                        break;
                    case "M":
                    case "m":
                        Console.Clear();
                        Console.WriteLine("Multiplyed: {0}", tal1 * tal2);
                        break;
                    case "D":
                    case "d":
                        Console.Clear();
                        Console.WriteLine("divied: {0}", tal1 / tal2);
                        break;

                    default:
                        continue;
                }
            }
        }
    }
}

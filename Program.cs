namespace Opgave_12
{
    internal class Program
    {
        static string email;
        static bool valid = false;
        static void Main(string[] args)
        {
            emailVerify();
        }

        static void emailVerify()
        {
            while (!valid)
            {
                Console.WriteLine("\nYou need to enter @gmail.com");
                Console.Write("Enter your email : ");
                email = Console.ReadLine();

                if (email.Contains("@gmail.com"))
                {
                    valid = true;
                    Console.Clear();
                    Console.WriteLine("Thank you for the Gmail! My good sir");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Fejl: Beskeden skal indholde @gmail.com");
                    return;
                }

            }

        }
    }
}

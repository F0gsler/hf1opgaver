namespace opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alder = Convert.ToInt32(Console.ReadLine());

            if (alder >= 18 )
            {
                Console.WriteLine("Du er møndig!");
            }

            else
            {
                Console.WriteLine("Du er ikke Møndig!");
            }
        }
    }
}

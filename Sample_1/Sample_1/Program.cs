class Program
{
    //Is The Number Even Or Odd?
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                int x; char y;

                Console.WriteLine("Please Enter Number:");
                x = Convert.ToInt32(Console.ReadLine());

                if (x % 2 == 0)
                {
                    Console.WriteLine("Number is Even!");
                }
                else
                {
                    Console.WriteLine("Number is Odd!");
                }
                Console.WriteLine("Continue?Y/N");
                y = Convert.ToChar(Console.ReadLine());
                if (y == 'N' || y == 'n')
                {
                    break;
                    Thread.Sleep(1000);
                    Console.WriteLine("Good Luck...");
                    Environment.Exit(0);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("****************");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Read And Check The Permissions!!!");
            Console.ResetColor();
        }
    }
}
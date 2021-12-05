class program
{
    public static void Main(string[] args)
    {
        //Find Factorial Number

        //int Number; int n;
        
        Console.WriteLine($"Please Enter Number:");
        Console.WriteLine(factorial());
        

        //Sample(1)
        //while (Number > 0)
        //{
        //    n = Number;
        //    for (int i = n - 1; i > 0; i--)
        //    {
        //        n *= i;
        //    }
        //    Console.WriteLine("Factorial of {0}! = {1}\n", Number, n);
        //    Number--;
        //}

    }
    //Sample(2)
    public static double factorial(int number = 0)
    {
        number = int.Parse(Console.ReadLine());
        double resulat = 1;
        while (number != 1)
        {
            resulat = resulat * number;
            number = number - 1;
        }
        return resulat;
    }
}
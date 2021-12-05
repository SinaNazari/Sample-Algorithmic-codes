class program
{
    static void Main(string[] args)
    {
        //Find Maximum Between Three Number

        int number1, number2, number3;

        Console.WriteLine("Please Enter Number One:");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter Number Tow:");
        number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter Number Three:");
        number3 = int.Parse(Console.ReadLine());

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"Number {number1} is Maximum Between Numbers");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"Number {number2} is Maximum Between Numbers");
        }
        else if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"Number {number3} is Maximum Between Numbers");
        }
    }
}
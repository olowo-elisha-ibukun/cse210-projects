using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your first number? ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("What is your second number? ");
        int second = int.Parse(Console.ReadLine());

        int sum = first + second;

        Console.WriteLine($"The sum is: {sum}");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squarednumber = SquareNumber(number);
        DisplayResult(name, squarednumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
       Console.WriteLine("Please enter your name:");
       string name = Console.ReadLine();
       return (name);
    } 
    static int PromptUserNumber()
    {
       Console.WriteLine("Please enter your favorite number:");
       int number = int.Parse(Console.ReadLine());
       return (number);
    }
    static int SquareNumber(int number)
    {
        int squarednumber = number * number;
        return (squarednumber);
    }
    static void DisplayResult(string name, int squarednumber)
    {
       Console.WriteLine($"{name}, the square of your number is {squarednumber}");
    }
}
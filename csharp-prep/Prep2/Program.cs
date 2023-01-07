using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        int decimal_number = percent%10;

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (decimal_number >= .7)
        {
            sign = "+";
        }
        else if (decimal_number < .3)
        {
            sign = "-";
        }
        string letter_n_sign = letter + sign;

        if (letter_n_sign == "A+")
        {
            letter_n_sign = "A";
        }
        else if (letter_n_sign == "F+" || letter_n_sign == "F-")
        {
            letter_n_sign = "F";
        }

        Console.WriteLine($"Your grade is: {letter_n_sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
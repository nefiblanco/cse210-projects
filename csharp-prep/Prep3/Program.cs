using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "";

        do{
        
            Random randomNumber = new Random();
            int createdNumber = randomNumber.Next(1, 101);

            int input = 0;
            int count = 0;
            while (input != createdNumber)
            {
                Console.Write("What is your guess? ");
                input = int.Parse(Console.ReadLine());

                if (createdNumber > input)
                {
                    Console.WriteLine("Higher");
                    count ++;
                }
                else if (createdNumber < input)
                {
                    Console.WriteLine("Lower");
                    count ++;
                }
                else
                {
                    Console.WriteLine($"You guessed it in {count} attempts!");
                }
            }

            Console.Write("Would you like to play again?");
            play = Console.ReadLine();

        }while(play == "yes");
    }
}
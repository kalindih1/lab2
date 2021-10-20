using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            do
            {
                string userInput = "";
                Console.WriteLine("What is the length");
                userInput = Console.ReadLine();


                float roomLength = float.Parse(userInput);

                Console.WriteLine("What is the width");

                userInput = Console.ReadLine();
                float roomWidth = float.Parse(userInput);

                float area = roomWidth * roomLength;

                float perimeter = (roomWidth * 2) + (roomLength * 2);

                Console.WriteLine($"Your area is {area} and your perimeter is {perimeter}");
                

                

                bool isValid = false;
                do
                {
                    Console.WriteLine("Play again?");
                    userInput = Console.ReadLine();


                    if (userInput.Trim().ToLower() == "no")
                    {

                        playAgain = false;
                        isValid = true;
                    }
                    else if (userInput.Trim().ToLower() == "yes")
                    {
                        isValid = true;

                    }
                    else
                    {
                        Console.WriteLine("Error ");

                    }
                }
                while (isValid == false);
                }

            while (playAgain == true);


            Console.WriteLine("Thanks for playing");
            Console.ReadKey();

        }
    }
}

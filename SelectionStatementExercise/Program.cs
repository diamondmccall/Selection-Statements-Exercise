﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("Try to guess my favorite number!");



            var r = new Random();

            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());


            if (userInput > favNumber)

            {
                Console.WriteLine("Too high! Not even close!");
            }

            else if (userInput < favNumber)


            {
                Console.WriteLine("Nevermind! Now you're a little too low!");
            }

            else if (userInput == favNumber)


            {
                Console.WriteLine("YESSS! GREAT GUESS!");
            }


          
            
        }
    }
}

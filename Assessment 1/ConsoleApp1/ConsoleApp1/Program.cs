using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string greeting = "Hello, user!";
            int playerScore = 0;
            string displayScore = "Your score is currently " + playerScore + ".";
            string something;

            Console.WriteLine(greeting);
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 10;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 20;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 30;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 40;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 50;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 60;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 70;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 80;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 90;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            something = Console.ReadLine();

            playerScore = 100;
            displayScore = "Your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);
            Console.WriteLine("You win!! Press any key to end the game.");

            //Wiat to end porgram
            Console.ReadKey();


            /*
           string givenName;
           Console.WriteLine("Hello! What is your name? ");
           givenName = Console.ReadLine();

           Console.WriteLine("Nice to meet you, " + givenName);
           Console.WriteLine("I hope you are well!");

           Console.WriteLine("Press any key to quit");
           Console.ReadKey();
            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICTPRG302_Intro_to_Programming
{
    internal class Gamertags
    {
        // the list of gamer tags loaded from file
        private string[] gamerTagList = { };

        // load a list of gamertags from file and store the resulting list in our gamertaglist
        public void LoadGamertags()
        {
            gamerTagList = File.ReadAllLines("../Gamertags.txt");
        }

        public void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Welcome to the Gamertag Database");
            Console.WriteLine("====================");
            Console.WriteLine("Hello!!!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // display all gametrga onnb tyhe console
        public void PrintAllGamertags()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("All Gamertags");
            Console.WriteLine("====================");

            // loop over te list of gamertagsand print each one out on a new line
            int lineNumber = 1; // this local variable  is used as a "bullet list" conuter nfor each line
            foreach (string s in gamerTagList)
            {
                Console.WriteLine(lineNumber.ToString() + ") " + s);

                lineNumber = lineNumber + 1;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void PrintGamertagsEndingWithNumber()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags ending with a number");
            Console.WriteLine("====================");

            // loop over te list of gamertagsand print each one out on a new line
            int lineNumber = 1; // this local variable  is used as a "bullet list" conuter nfor each line
            foreach (string s in gamerTagList)
            {
                if ((s.Length > 0) && Char.IsNumber(s, s.Length - 1))
                {
                    Console.WriteLine(lineNumber.ToString() + ") " + s);

                    lineNumber = lineNumber + 1;
                }
            }

            // display a mesga to the use r & wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}

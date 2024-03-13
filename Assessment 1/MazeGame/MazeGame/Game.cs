using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Game
    {
        //Variables here
        Vector2 directionInput = new Vector2();

        //Direction Input
        //int xDirInput = 0;
        //int yDirInput = 0;

        //Player position
        Vector2 playerPosition = new Vector2(10,10);
        //int xPos = 10;
        //int yPos = 10;

        //World Size
        string[,] levelMap =
        {
            { "f", "u", "r", "-", "m", "a", "z", "e", "-", "i", "n", "g", ".", ".", "(", "h", "e", "l", "p", ")"},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { "0", "0", "0", "0", "0", "0", ".", ".", ".", ".", ".", ".", ".", "0", "0", "0", "0", "0", "0", "."},
            { "0", ".", ".", ".", ".", "0", ".", ".", ".", ".", ".", ".", ".", "0", ".", ".", ".", ".", "0", "."},
            { "0", ".", ".", ".", ".", "0", ".", ".", ".", ".", ".", ".", ".", "0", ".", ".", ".", ".", "0", "."},
            { "0", ".", ".", ".", ".", "0", ".", "0", ".", ".", ".", "0", ".", "0", ".", ".", ".", ".", "0", "."},
            { "0", ".", ".", ".", ".", "0", ".", "0", ".", "0", ".", "0", ".", "0", ".", ".", ".", ".", "0", "."},
            { "0", ".", ".", ".", ".", "0", ".", "0", ".", "0", ".", "0", ".", "0", ".", ".", ".", ".", "0", "."},
            { "0", "0", "0", "0", "0", "0", "_", "0", "0", "0", "0", "0", "_", "0", "0", "0", "0", "0", "0", "_"},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { "t", "r", "y", "_", "t", "o", "_", "e", "s", "c", "a", "p", "e", ".", ">", "w", "<", "_", "_", "_"},
         };

        bool exit = false;

        public Game()
        {
            Draw();

            while(exit == false)
            {
                Inputs();
                Update();
                Draw();
            }
            
        }

        //Function here
        void Inputs()
        {
            ConsoleKey input = Console.ReadKey().Key;
            switch (input)
            {
                case ConsoleKey.Escape:
                    exit = true;
                    break;
                case ConsoleKey.W:
                    directionInput.y = -1;
                    //yDirInput = -1;
                    break;
                case ConsoleKey.S:
                    directionInput.y = 1;
                    //yDirInput = 1;
                    break;
                case ConsoleKey.A:
                    directionInput.x = -1;
                    //xDirInput = -1;
                    break;
                case ConsoleKey.D:
                    directionInput.x = 1;
                    //xDirInput = 1;
                    break;
            }
        }

        void Update()
        {
            Vector2 previousPosition = playerPosition;

            //Set player position
            //xPos += xDirInput;
            //yPos += yDirInput;

            playerPosition += directionInput;


            //Check if left screen, if so, put back where it came from
            if (playerPosition.x < 0)
            {
                playerPosition.x = 0; //Setting xPos to 0
            }
            if (playerPosition.y < 0)
            {
                playerPosition.y++; //adding one to move it back
            }
            if (playerPosition.y > levelMap.GetLength(0) - 1)
            {
                playerPosition.y = levelMap.GetLength(0) - 1;
            }
            if (playerPosition.x > levelMap.GetLength(1) - 1)
            {
                playerPosition.x = levelMap.GetLength(1) - 1;
            }

            if (levelMap[playerPosition.y, playerPosition.x] != ".")
            {
                playerPosition = previousPosition;
            }

            directionInput = new Vector2();
        }

        void Draw()
        {
            Console.Clear();
            //create string to be our drawing
            string screen = "";

            for (int y = 0; y < levelMap.GetLength(1); y++)
            {
                for (int x = 0; x < levelMap.GetLength(0); x++)
                {
                    if (playerPosition.x == x && playerPosition.y == y)
                    {
                        screen += ":3";
                    }
                    else
                    {
                        screen += " " + levelMap[y, x];
                    }
                }
                screen += "\n";
            }

            Console.WriteLine(screen);
        }

    }
}

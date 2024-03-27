using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Game
    {
        //Variables here
        Vector2 directionInput = new Vector2();

        string[,] levelMap = new string[20, 20];

        //Direction Input
        //int xDirInput = 0;
        //int yDirInput = 0;

        //Player position
        Vector2 playerPosition = new Vector2(10,10);
        //int xPos = 10;
        //int yPos = 10;

        bool exit = false;

        public Game()
        {
            LoadLevel();

            //SaveLevel();
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

        public void SaveLevel()
        {
            string level = "";

            for (int y=0; y< levelMap.GetLength(1); y++)
            {
                for (int x = 0; x < levelMap.GetLength(0); x++)
                {
                    level += levelMap[y, x];
                }
                level += "\n";
            }

            File.WriteAllText("level.txt", level);
        }


        void LoadLevel()
        {
            string level = File.ReadAllText("level.txt");
            int x = 0;
            int y = 0;

            for (int i = 0; i < level.Length; i++)
            {
                if (level[i] == '\n')
                {
                    y++;
                    x = 0;
                    continue;
                }
                levelMap[y, x] = level[i].ToString();
                x++;
            }
        }
    }
}

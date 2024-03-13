using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches
{
    internal class Program
    {
        static void Main()
        {
            int playerHealth = 100;
            int monsterDamage = 1;
            playerHealth -= monsterDamage;

            if(playerHealth < 0)
            {
                playerHealth = 0;
            }

            Console.WriteLine("A monster attacked you and did " + monsterDamage + " damage! You have " + playerHealth + " health left.");
            if (playerHealth == 0)
            {
                Console.WriteLine("You died lmao. Game over, loser!!!");
            }
            else if(playerHealth > 0)
            {
                Console.WriteLine("The monster prepares to attack you again...");
            }
            else if (monsterDamage > 50)
            {
                Console.WriteLine("The attack was very affective!");
            }
            Console.ReadKey();
        }
    }
}

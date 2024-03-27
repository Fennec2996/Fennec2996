using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadAndWrite readAndWrite = new ReadAndWrite();
            readAndWrite.ReadFile();
            readAndWrite.WriteOutNameList();

            Console.WriteLine("Please add a name");
            // grabbing new name to add to list
            string newName = Console.ReadLine();
            if(newName.Length > 0)
            {
                // write to file
                readAndWrite.AddNameToList(newName);
                readAndWrite.WriteToFile();
            }
        }
    }
}

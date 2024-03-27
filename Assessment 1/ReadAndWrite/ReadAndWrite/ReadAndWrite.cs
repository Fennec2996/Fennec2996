using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAndWrite
{
    internal class ReadAndWrite
    {
        private string fileName = @"..\GameNames.txt";
        private List<string> characterNames = new List<string>();

        public void ReadFile()
        {
            string[] tempArray = File.ReadAllLines(fileName);
            foreach (string item in tempArray)
            {
                characterNames.Add(item);
            }
        }

        public void WriteOutNameList()
        {
            foreach(string characterName in characterNames)
            {
                Console.WriteLine(characterName);
            }
            Console.ReadKey();
        }

        public void AddNameToList(string newName)
        {
            characterNames.Add(newName);
        }

        public void RemoveNameFromList(string nameToRemove)
        {
            characterNames.Remove(nameToRemove);
        }

        public void WriteToFile()
        {
            File.WriteAllLines(fileName, characterNames);
        }
    }
}

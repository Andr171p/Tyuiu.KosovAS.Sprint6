using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovAS.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string str, string path)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\andre\source\repos\Tyuiu.KosovAS.Sprint6\DataTask6\InPutFileTask6V30.txt");
            string fourthWord = "";
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');

                if (words.Length >= 4)
                {
                    List<string> list = new List<string>();
                    for (int i = 0; i < words.Length; i++)
                    {
                        fourthWord = words[3];
                        list.Add(fourthWord);
                    }
                }
            }
           return fourthWord;
        }
    }
}

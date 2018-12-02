using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 2");
            Console.WriteLine("Part 1");

            var dataFile = File.ReadAllLines(@"C:\Input\AoC\Day1\data.txt");
            var dataList = new List<string>(dataFile);
            int freq = 0;
            foreach (string s in dataList)
            {
                freq += int.Parse(s);

            }
            Console.WriteLine(freq);
            Console.WriteLine("Part 2");
            
            

            freq = 0;
            int freqStore = 0;
            List<int> SeenFreq = new List<int>();
            bool done = false;
            while (!done)
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    SeenFreq.Add(freq);
                    freq += int.Parse(dataList[i]);
                    if (SeenFreq.Contains(freq))
                    {
                        Console.WriteLine(freq);
                        done = true;
                    }
                        
                }
            }
            Console.WriteLine(freq);

            Console.ReadLine();

        }
    }
}

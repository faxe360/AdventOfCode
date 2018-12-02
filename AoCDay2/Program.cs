using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 2");
            Console.WriteLine("Part 1");
            int twos = 0;
            int threes = 0;
            var dataFile = File.ReadAllLines(@"C:\Input\AoC\Day2\data.txt");
            foreach (string s in dataFile)
            {
                var counted = s.GroupBy(x => x)
                    .ToDictionary(l => l.Key, l => l.Count());
                if (counted.ContainsValue(2))
                    twos++;
                //twos += counted.Count(x => x.Value == 2);
                if (counted.ContainsValue(3))
                    threes++;
                //threes += counted.Count(x => x.Value == 3);
            }
            Console.WriteLine("CheckSum: " + twos * threes);
            Console.WriteLine("Part2");
            foreach (string s in dataFile)
            {
                char[] sa = s.ToCharArray();
                
                foreach (string b in dataFile)
                {
                    char[] ba = b.ToCharArray();

                    int counter = 0;
                    for (int i= 0; i < sa.Length;i++)
                    {

                        if (sa[i] == ba[i])
                        {
                            counter++;
                        }
                    }
                    if (counter == 25)
                    {
                        Console.WriteLine(s);
                        Console.WriteLine(b);
                        Console.WriteLine("---");
                    }
                    counter = 0;

                }
            }
            Console.ReadLine();
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoCDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 3");
            Console.WriteLine("Part 1");
            List<Claim> ClaimList = new List<Claim>();
            int[,] ClaimMap = new int[1000, 1000];

            var dataFile = File.ReadAllLines(@"C:\Input\AoC\Day3\data.txt");
            foreach (string s in dataFile)
            {
                string[] split = s.Split(' ');
                Claim c = new Claim()
                {
                    ID = int.Parse(split[0].Replace("#", "").Trim()),
                    x = int.Parse(split[2].Replace(":", "").Split(',')[0]),
                    y = int.Parse(split[2].Replace(":", "").Split(',')[1]),
                    width = int.Parse(split[3].Split('x')[0]),
                    height = int.Parse(split[3].Split('x')[1])
                };

                for (int x = c.x; x < c.x+c.width; x++)
                {
                    for (int y = c.y; y < c.y+c.height; y++)
                    {
                        ClaimMap[x, y] += 1;
                    }
                }
                ClaimList.Add(c);
            }
        
            int counterMoreThanOne=0;
            for (int x = 0; x < 1000; x++)
            {
                for (int y = 0; y < 1000; y++)
                {
                    if (ClaimMap[x, y] > 1)
                        counterMoreThanOne++;
                }
            }
            Console.WriteLine(counterMoreThanOne);
            Console.WriteLine("Part2");

            int counterOne = 0;
            foreach (Claim c in ClaimList)
            {

                for (int x = c.x; x < c.x + c.width; x++)
                {
                    for (int y = c.y; y < c.y + c.height; y++)
                    {
                        if (ClaimMap[x, y] != 1)
                            counterOne++;
                    }
                }
                if (counterOne==0)
                    Console.WriteLine(c.ID+" is all alone");
                counterOne = 0;

            }




            Console.WriteLine("Finished");
        Console.ReadLine();

        }

    }
    public class Claim
        {
        public int ID { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    
}

using System;
using System.Linq;

namespace Advent2
{
    public class Password
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int finder(string[] input)
        {
            int count = 0;

            foreach (string line in input)
            {
                string[] sections = line.Split(' ');

                string range = sections[0];

                char letter = Convert.ToChar(sections[1].TrimEnd(':'));

                string letters = sections[2];

                int frequency = letters.Count(l => (l == letter));

                int lowindex = Int32.Parse(range.Split('-')[0]) - 1;
                int highindex = Int32.Parse(range.Split('-')[1]) - 1;

                if (letters[lowindex] == letter && letters[highindex] != letter)
                {
                    count++;
                }
                if (letters[lowindex] != letter && letters[highindex] == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

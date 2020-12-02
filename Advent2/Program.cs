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

                int lowRange = Int32.Parse(range.Split('-')[0]);
                int highRange = Int32.Parse(range.Split('-')[1]);

                if (frequency >= lowRange && frequency <= highRange)
                {
                    count++;
                }

            }
            return count;
        }
    }
}

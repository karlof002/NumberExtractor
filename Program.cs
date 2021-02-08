using System;

namespace NumberExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            long number=0;
            Console.Write("Eingabetext:");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= '0') && (input[i] <= '9'))
                {
                    number = number * 10 + (input[i] - '0');
                }
            }

            Console.WriteLine("Die enthaltene Zahl lautet {0}. Das Doppelte der Zahl lautet {1}",number,number*2);
        }
    }
}

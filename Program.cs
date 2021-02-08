/***********************************************************************************************                                     
 * Programmname:    NumberExtractor
 * Autor:           Michael Bucek                             
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Es soll ein Text bestehend aus beliebigen Zeichen eingelesen werden. Alle im Text enthaltenen
 * Ziffern sollen zu einer Zahl zusammengefügt werden. Diese Zahl und das Doppelte dieser Zahl soll ausgegeben werden!
 ************************************************************************************************/


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

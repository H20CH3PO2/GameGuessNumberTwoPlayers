using System;

namespace GameGuess
{
    // Заспавнить 
    class Program
    {
        public static int Foo(String str)
        {
            return 5;
        }
        static void Main(string[] args)
        {
            int inputNumberfortuneTeller = -1;
            int inputNumberGuesser = -2;
            bool isFirst = false;
            do {
                isFirst = !isFirst;
                if (isFirst)
                {
                    Console.WriteLine("Put your number for riddle first player!");
                    inputNumberfortuneTeller = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Put your number for guess second player!");
                    inputNumberGuesser = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Put your number for riddle second player!");
                    inputNumberfortuneTeller = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Put your number for guess first player!");
                    inputNumberGuesser = Convert.ToInt32(Console.ReadLine());
                }
                
            } while (inputNumberfortuneTeller != inputNumberGuesser);
            if (!isFirst)
            {
                Console.WriteLine("Yahu! First pleyer win!");
                Console.WriteLine(inputNumberfortuneTeller);
            }
            else
            {
                Console.WriteLine("Yahu! Second pleyer win!");
                Console.WriteLine(inputNumberGuesser);
            }

        }
    }
}

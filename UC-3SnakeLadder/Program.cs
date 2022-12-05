using System;

namespace UC_3SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Random random = new Random();
            int dicevalue = random.Next(6);
            Console.WriteLine("Dice value is =" + dicevalue);

            int option = random.Next(3);
            if (option == 0)
            {
                Console.WriteLine("no play stays in same position");
            }
            else if (option == 1)
            {
                position += dicevalue;
                Console.WriteLine(" Ladder player moves ahead then the position:" + position);
            }
            else
            {
                position -= dicevalue;
                Console.WriteLine(" Snake moves behind the number then the position:" + position);
            }
        }
    }
}

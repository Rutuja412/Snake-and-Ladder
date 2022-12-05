using System;

namespace UC_2SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dicevalue = random.Next(6);
            Console.WriteLine("Rolling dice value is =" + dicevalue);
        }
        
    }
    
}

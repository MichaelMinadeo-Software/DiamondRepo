using System;

namespace Diamond
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\n");
            Console.WriteLine("  |$$$|     |$$$|     |$$ $$$|     |$$$|     |$$$|");
            Console.WriteLine("  |$$$$|   |$$$$|     |$$   $$|    |$$$$|   |$$$$|");
            Console.WriteLine("  |$$| |$$$| |$$|     |$$ $$$|     |$$| |$$$| |$$|");
            Console.WriteLine("  |$$|  |$|  |$$|     |$$|         |$$|  |$|  |$$|");
            Console.WriteLine("  |$$|       |$$|     |$$|         |$$|       |$$|");
            Console.WriteLine("  |$$|       |$$|     |$$|         |$$|       |$$|");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("      - A solution by Michael Paul Minadeo");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("-------------------------------------------------------------------------------------------------------------------  ");
            Console.Write("\n");
            Console.Write("\n");

            Console.Write("Enter middle Character to create Diamond, or 0 (Zero) to exit: ");
            while(true)
            {
                var c = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                if(c.Equals('0'))
                {
                    break;
                }

                DiamondCreator.GenerateDiamond(c);
                Console.Write("\n");
                Console.Write("Enter middle Character to create Diamond, or 0 (Zero) to exit: ");
            }
        }
    }
}

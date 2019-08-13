using System;

namespace Diamond
{
    public class DiamondCreator
    {
        private static int CheckChar(char c)
        {
            var rows = 0;

            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
            { 
                var ch = char.ToUpper(c);
                rows = (ch - 64) * 2 - 1;
            }
            else
            {
                Console.WriteLine(c + " is not a valid input.");
                Console.Write("PLease enter a letter from the alphabet: ");
                var n = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                GenerateDiamond(n);
            }
            return rows;
        }

        public static void GenerateDiamond(char input)
        {
            var rows = CheckChar(input);
            Print(rows);
        }


        private static void Print(int n)
        {
            var rows = Math.Ceiling((decimal) n / 2);
            // run loop   
            // till number of rows 
            var outsideSpace = (int) rows;
            var insideSpace = 1;

            for (var i = 1; i <= rows; i++)
            {
                for (var k = 1; k < outsideSpace; k++) Console.Write(" ");

                for (var j = 1; j <= i; j++)
                {
                    if (j >= 3) break;
                    Console.Write((char) (i + 64));

                    for (var k = 1; k < insideSpace; k++) Console.Write(" ");
                }


                outsideSpace--;
                insideSpace += 2;


                Console.Write("\n");
            }

            // Repeat again in reverse order minus one row (entered character only gets one row)
            var down = n - rows;
            insideSpace -= 2;

            // run loop (parent loop) 
            // till number of rows 
            for (var i = (int) down; i > 0; i--)
            {
                outsideSpace++;
                insideSpace -= 2;

                for (var k = 1; k <= outsideSpace; k++) Console.Write(" ");

                for (var j = 1; j <= i; j++)
                {
                    // Don't want to fill in the diamond
                    if (j >= 3) break;
                    Console.Write((char) (i + 64));

                    for (var k = 1; k < insideSpace; k++) Console.Write(" ");
                }

                Console.Write("\n");
            }
        }
    }
}
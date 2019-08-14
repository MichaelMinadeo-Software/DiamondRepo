using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class CheckInput
    {
        public static char Character;

        // Validates input is char, or asks for another char if invalid
        public static char CheckChar(char c)
        {

            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
            {
                Character = char.ToUpper(c);
            }
            else
            {
                
                Console.WriteLine(c + " is not a valid input.");
                Console.Write("\n");
                Console.Write("PLease enter a letter from the alphabet: ");
                var newChar = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                Character = char.ToUpper(newChar);

            }
            return Character;
        }
    }
}

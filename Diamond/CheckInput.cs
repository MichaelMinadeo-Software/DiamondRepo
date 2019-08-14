// ***********************************************************************
// Assembly         : Diamond
// Author           : rr333491
// Created          : 08-13-2019
//
// Last Modified By : rr333491
// Last Modified On : 08-13-2019
// ***********************************************************************
// <copyright file="CheckInput.cs" company="RR Donnelley">
//     Copyright © RR Donnelley 2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    /// <summary>
    /// Class CheckInput.
    /// </summary>
    public class CheckInput
    {
        /// <summary>
        /// The character
        /// </summary>
        public static char Character;

        // Validates input is char, or asks for another char if invalid
        /// <summary>
        /// Checks the character.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>System.Char.</returns>
        /// <exception cref="InvalidOperationException"></exception>
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

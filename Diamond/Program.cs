// ***********************************************************************
// Assembly         : Diamond
// Author           : rr333491
// Created          : 08-12-2019
//
// Last Modified By : rr333491
// Last Modified On : 08-13-2019
// ***********************************************************************
// <copyright file="Program.cs" company="RR Donnelley">
//     Copyright © RR Donnelley 2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Diamond
{
    /// <summary>
    /// Class Program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="InvalidOperationException"></exception>
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

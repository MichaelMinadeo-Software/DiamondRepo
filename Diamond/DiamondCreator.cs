// ***********************************************************************
// Assembly         : Diamond
// Author           : Michael Minadeo
// Created          : 08-12-2019
//
// Last Modified By : Michael Minadeo
// Last Modified On : 08-13-2019
// ***********************************************************************
// <copyright file="DiamondCreator.cs" company="RR Donnelley">
//     Copyright © RR Donnelley 2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Diamond
{
    /// <summary>
    /// Class DiamondCreator.
    /// </summary>
    public class DiamondCreator
    {
        /// <summary>
        /// Generates the diamond.
        /// </summary>
        /// <param name="input">The input.</param>
        public static void GenerateDiamond(char input)
        {
           
            var letter = CheckInput.CheckChar(input);
            var rows = RowCount.GetRowCount(letter);
            PrintDiamond.Print(rows);
        }   
    }
}
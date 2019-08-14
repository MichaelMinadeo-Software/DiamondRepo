// ***********************************************************************
// Assembly         : Diamond
// Author           : rr333491
// Created          : 08-13-2019
//
// Last Modified By : rr333491
// Last Modified On : 08-13-2019
// ***********************************************************************
// <copyright file="RowCount.cs" company="RR Donnelley">
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
    /// Class RowCount.
    /// </summary>
    public class RowCount
    {

        //Gets the Row Count based on the letter input
        /// <summary>
        /// Gets the row count.
        /// </summary>
        /// <param name="letter">The letter.</param>
        /// <returns>System.Int32.</returns>
        public static int GetRowCount(char letter)
        {
            var rows = (letter - 64) * 2 - 1;
            return rows;
        }
    }
}

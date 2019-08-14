using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class RowCount
    {

        //Gets the Row Count based on the letter input
        public static int GetRowCount(char letter)
        {
            var rows = (letter - 64) * 2 - 1;
            return rows;
        }
    }
}

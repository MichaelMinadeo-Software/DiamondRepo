using System;

namespace Diamond
{
    public class DiamondCreator
    {
        public static void GenerateDiamond(char input)
        {
           
            var letter = CheckInput.CheckChar(input);
            var rows = RowCount.GetRowCount(letter);
            PrintDiamond.Print(rows);
        }   
    }
}
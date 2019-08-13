using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter middle Character: ");
            var c = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            DiamondCreator.GenerateDiamond(c);

        }
    }
}

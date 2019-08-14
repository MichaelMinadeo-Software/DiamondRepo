using System;
using System.Collections.Generic;
using Diamond;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiamondTests
{
    [TestClass]
    public class DiamondTests
    {
       
        [TestMethod]
        public void MakeSureInputIsALetterInTheAlphabet()
        {
            // setup, can be any letter in alphabet
            var input = char.ToUpper('d');

            // Make sure method returns correct result
            var generated = CheckInput.CheckChar(input);

            Assert.AreEqual(input, generated);

        }

        [TestMethod]
        public void MakeSureInvalidInputGetsChanged()
        {
            //setup
            var input = '@';

            // check for character validity
            if (input >= 'a' && input <= 'z' || input >= 'A' && input <= 'Z')
            {
                input = '@';
            }
            else
            {
                // Any letter, just need to see the input changed from invalid character
                input = 'C';
            }

            // generate an output for comparison
            var generated = CheckInput.CheckChar(input);

            Assert.AreEqual(input, generated );


        }


        [TestMethod]
        public void CheckLetterReturnsCorrectAmountOfRowsForC()
        {
            // Any valid character to check rows
            var c = char.ToUpper('c');

            // generate amount of rows from letter
            var rows = RowCount.GetRowCount(c);

            Assert.AreEqual(5, rows);
        }

        [TestMethod]
        public void CheckLetterReturnsCorrectAmountOfRowsForM()
        {
            // Any valid character to check rows
            var m = char.ToUpper('m');

            // generate amount of rows from letter
            var rows = RowCount.GetRowCount(m);


            Assert.AreEqual(25, rows);
        }

    }
    
}

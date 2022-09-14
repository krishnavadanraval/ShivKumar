using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintDiamondPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace PrintDiamondMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PasscaseInput()
        {
            Console.SetIn(new StringReader("F"));
            //
            string input = PrintDiamondPattern.Program.UserInput();

            Assert.AreEqual("F", input);
        }

      

        [TestMethod()]
        public void FailcaseInputString()
        {

            Console.SetIn(new StringReader("String"));

            string input = PrintDiamondPattern.Program.UserInput();


            string errorMessage = "Invalid input - String,Input must be in Upper case between A and Z";

            Assert.AreEqual(errorMessage, input);
        }

        [TestMethod()]
        public void FailcaseInputNumber()
        {
            Console.SetIn(new StringReader("2"));

            string input = PrintDiamondPattern.Program.UserInput();

            string errorMessage = "Invalid input - Number,Input must be in Upper case between A and Z";

            Assert.AreEqual(errorMessage, input);
        }
        [TestMethod()]
        public void FailcaseInputSpecialChar()
        {
            Console.SetIn(new StringReader("$"));

            string input = PrintDiamondPattern.Program.UserInput();

            string errorMessage = "Invalid input - Special character,Input must be in Upper case between A and Z ";

            Assert.AreEqual(errorMessage, input);
        }
        [TestMethod()]
        public void FailcaseInputSmallLetter()
        {
            Console.SetIn(new StringReader("f"));

            string input = PrintDiamondPattern.Program.UserInput();

            string errorMessage = "Invalid input - small alphabet character,Input must be in Upper case between A and Z ";

            Assert.AreEqual(errorMessage, input);
        }

    }
}
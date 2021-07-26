using System;
using DEV_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramTests
{
    [TestClass]
    public class UnitTest1
    {
        // "abcdaaccdaa123111"
        // "111234511"
        // ",,".;~%#$##$!"
        // "112wad,,zs.ca;;,qmqwd,;12312,md;qwd,12;,d;1,2"
        // " "
        // "   "
        // " ac 123   12f04"
        // "чацуа 123   ачсуацу 11 4"

        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns5()
        {
            Program program = new Program();
           int result = program.GetMaxNumberOfDifferentSymbolsConsecutive("abcdaaccdaa123111");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns6()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive("111234511");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns9()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive(",,\".;~%#$##$!");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns31()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive("112wad,,zs.ca;;,qmqwd,;12312,md;qwd,12;,d;1,2");
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns0()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive(" ");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns00()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive("  ");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns8()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive(" ac 123   12f04");
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns10()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive("чацуа 123   ачсуацу 11 4");
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfDifferentSymbolsConsecutiveReturns000()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfDifferentSymbolsConsecutive("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns2_1()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive("abcdaaccdaa123111");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns2()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive("111234511");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns0()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive(",,\".;~%#$##$!");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns2_2()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive("112wad,,zs.ca;;,qmqwd,;12312,md;qwd,12;,d;1,2");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns0_1()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive(" ");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns0_2()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive("  ");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns1()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive(" ac 123   12f04");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns2_3()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive("чацуа 123   ачсуацу 11 4");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameNumbersConsecutiveReturns000()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameNumbersConsecutive("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns2_1()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive("abcdaaccdaa123111");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns0_0()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive("111234511");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns0()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive(",,\".;~%#$##$!");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns1_2()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive("112wad,,zs.ca;;,qmqwd,;12312,md;qwd,12;,d;1,2");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns0_1()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive(" ");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns0_2()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive("  ");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns1()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive(" ac 123   12f04");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns0_00()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive("чацуа 123   ачсуацу 11 4");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestGetMaxNumberOfSameLettersConsecutiveReturns000()
        {
            Program program = new Program();
            int result = program.GetMaxNumberOfSameLettersConsecutive("");
            Assert.AreEqual(0, result);
        }
    }
}

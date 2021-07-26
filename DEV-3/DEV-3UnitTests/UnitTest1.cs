using System;
using DEV_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_3UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestTransliterateReturns_WhiteSpace()
        {
            Transliterator transliterator = new Transliterator();
            string result = transliterator.Transliterate(" ");
            Assert.AreEqual(" ", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "String[] is invalid")]
        public void TestTransliterateReturns_Exception()
        {
            Transliterator transliterator = new Transliterator();
            string result = transliterator.Transliterate("");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void TestTransliterateReturns_RussianSumbols()
        {
            Transliterator transliterator = new Transliterator();
            string result = transliterator.Transliterate("asd by");
            Assert.AreEqual("аcд бы", result);
        }

        [TestMethod]
        public void TestTransliterateReturns_EnglishSumbols()
        {
            Transliterator transliterator = new Transliterator();
            string result = transliterator.Transliterate("бибидибабидибум");
            Assert.AreEqual("bibidibabidibum", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "String[asdтащи] is invalid")]
        public void TestTransliterateReturns_Exception2()
        {
            Transliterator transliterator = new Transliterator();
            string result = transliterator.Transliterate("asdтащи");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "String[123] is invalid")]
        public void TestTransliterateReturns_Exception3()
        {
            Transliterator transliterator = new Transliterator();
            string result = transliterator.Transliterate("123");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "String[jbvfhb; ] is invalid")]
        public void TestTransliterateReturns_Exception4()
        {
            Transliterator transliterator = new Transliterator();
            string result = transliterator.Transliterate("jbvfhb; ");
            Assert.AreEqual(null, result);
        }
    }
}

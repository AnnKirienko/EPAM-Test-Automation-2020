using System;

namespace Calculator
{
    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void EnsureCalculatorWorksCorrectly()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--log-level=3");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                CalculatorPage calculatorPage = new CalculatorPage(driver);

                TestInvoker invoker = new TestInvoker(calculatorPage);

                Assert.AreEqual(invoker.GetResult("2+3"), "5");
                Assert.AreEqual(invoker.GetResult("183*3+2"), "551");
                Assert.AreEqual(invoker.GetResult("147/9"), "16.3333");
            }
        }
    }
}

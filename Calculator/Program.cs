using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--log-level=3");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                CalculatorPage calculatorPage = new CalculatorPage(driver);

                TestInvoker invoker = new TestInvoker(calculatorPage);

                Console.WriteLine("======");
                Console.WriteLine(invoker.GetResult("2+3"));
                Console.WriteLine(invoker.GetResultAndExpression("2+3"));
                Console.WriteLine(invoker.GetResult("183*3+2"));
                Console.WriteLine(invoker.GetResultAndExpression("183*3+2"));
                Console.WriteLine("======");

                Thread.Sleep(6000);
            }
        }

    }
}

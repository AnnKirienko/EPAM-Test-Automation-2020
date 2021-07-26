using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Metanit
{
    public class CSharpPage
    {
        private IWebDriver driver;
        private WebDriverWait driverWait;

        private string articleNamesSelector = ".centerRight > h3";

        public CSharpPage(IWebDriver driver, WebDriverWait driverWait)
        {
            this.driver = driver;
            this.driverWait = driverWait;
            this.driver.Manage().Window.Maximize();
        }

        private IReadOnlyCollection<IWebElement> FindTextElements()
        {
            return driver.FindElements(By.CssSelector(articleNamesSelector));
        }

        public void PrintTextElements()
        {
            foreach (var el in FindTextElements())
            {
                Console.WriteLine(el.Text + " ");
            }
        }



    }
}

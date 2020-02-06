using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Metanit
{
    public class MainPage
    {
        private IWebDriver driver;
        private WebDriverWait driverWait;
        private string url = @"http://metanit.com";
        private string cSharpButtonSelector = "#menT>div>a:nth-child(1)";
        private string nextPageSelector = "#articleText>div.centerRight>h2";

        public MainPage(IWebDriver driver, WebDriverWait driverWait)
        {
            this.driver = driver;
            this.driverWait = driverWait;
            this.driver.Manage().Window.Maximize();
        }

        public void OpenMainPage()
        {
            Console.WriteLine("Page was opened");
            driver.Navigate().GoToUrl(url);
        }

        private IWebElement FindEl()
        {
            Console.WriteLine("Button will be clicked");
            IWebElement cSharpButton = driver.FindElement(By.CssSelector(cSharpButtonSelector));
            // TODO: check for null
            return cSharpButton;
        }

        public CSharpPage ClickToC_SharpButton()
        {
            IWebElement cSharpButton = this.FindEl();

            cSharpButton.Click();
            Console.WriteLine("Button was clicked");

            driverWait.Until(d => d.FindElement(By.CssSelector(nextPageSelector)).Displayed);
            Console.WriteLine("waiting");

            return new CSharpPage(driver, driverWait);
        }
    }
}

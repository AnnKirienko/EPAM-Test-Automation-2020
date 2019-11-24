using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "annet_kiri228@mail.ru";
            const string password = "Mama_Myla_Ramu123";

            const string loginFieldSelector = "input[name=login]";
            const string passwordFieldSelector = "input[name = password]";
            const string controlButtonSelector = "input.o-control";
            const string unreadMessagesSelector = ".badge__text";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--log-level=3");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

                driver.Navigate().GoToUrl("https://mail.ru/");

                IWebElement loginInputForm = driver.FindElement(By.CssSelector(loginFieldSelector));
                loginInputForm.SendKeys(login);

                IWebElement inputButton = driver.FindElement(By.CssSelector(controlButtonSelector));
                inputButton.Click();

                driverWait.Until(d => d.FindElement(By.CssSelector(passwordFieldSelector)).Displayed);

                IWebElement passwordInputForm = driver.FindElement(By.CssSelector(passwordFieldSelector));
                passwordInputForm.SendKeys(password);

                IWebElement loginButton = driver.FindElement(By.CssSelector(controlButtonSelector));
                loginInputForm.Submit();

                driverWait.Until(d => d.FindElement(By.CssSelector(unreadMessagesSelector)).Displayed);

                string unreadMessagesNumber = driver.FindElement(By.CssSelector(unreadMessagesSelector)).Text;
                Console.WriteLine($"You have {unreadMessagesNumber} unread messages");
            }
        }
    }
}

using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string email = "ivolga.petrova.78@gmail.com";
            const string password2 = @"q8g%1\0802b$,1V3";
            const string login = "annet_kiri228@mail.ru";
            const string password = "Mama_Myla_Ramu123";
            const string recepient = email;
            const string textOfMessage = "hello";
            

            const string loginFieldSelector = "input[name=login]";
            const string passwordFieldSelector = "input[name = password]";
            const string signInButtonSelector = "h-c-header__nav-li-link[ga-event-action=\"sign in\"]";
            const string controlButtonSelector = "input.o-control";
            const string writeMessageSelector = ".compose-button.compose-button_white.compose-button_short.js-shortcut";
            const string containerSelector = ".container--H9L5q.size_s--3_M-_";
            const string textFieldSelector = ".editable-55qj > div:nth-child(1) > div:nth-child(1)";
            const string sendMessageButtonSelector = ".button2.button2_base.button2_primary.button2_compact.button2_hover-support.js-shortcut";
            const string inputEmailSelector = "input[type=\"email\"]";
            const string inputEmailButtonSelector = ".RveJvd.snByac";
            const string inputPasswordSelector = "input[type=\"password\"]";
            const string inputPasswordButtonSelector = ".RveJvd.snByac";
            const string mailBoxSelector = ".zA.zE";
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--log-level=3");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

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

                driverWait.Until(d => d.FindElement(By.CssSelector(writeMessageSelector)).Displayed);

                //IWebElement writeMessageButton = driver.FindElement(By.CssSelector(writeMessageSelector));
                //writeMessageButton.Click();

                //driverWait.Until(d => d.FindElements(By.CssSelector(containerSelector)).Count > 0);


                //ReadOnlyCollection<IWebElement> recipientInputForm = driver.FindElements(By.CssSelector(containerSelector));
                //recipientInputForm[0].SendKeys(recepient);

                //IWebElement textInputForm = driver.FindElement(By.CssSelector(textFieldSelector));
                //textInputForm.SendKeys(textOfMessage);

                //IWebElement sendMessageButton = driver.FindElement(By.CssSelector(sendMessageButtonSelector));
                //sendMessageButton.Click();

                driver.Navigate().GoToUrl("https://gmail.com/");

                //IWebElement signInButton = driver.FindElement(By.CssSelector(signInButtonSelector));
                //signInButton.Click();

                //driverWait.Until(d => d.FindElement(By.CssSelector(inputEmailSelector)).Displayed);

                IWebElement emailInputForm = driver.FindElement(By.CssSelector(inputEmailSelector));
                emailInputForm.SendKeys(email);

                IWebElement emailInputButton = driver.FindElement(By.CssSelector(inputEmailButtonSelector));
                emailInputButton.Click();

                driverWait.Until(d => d.FindElement(By.CssSelector(inputPasswordSelector)).Displayed);

                IWebElement passwordInputForm2 = driver.FindElement(By.CssSelector(inputPasswordSelector));
                passwordInputForm2.SendKeys(password2);

                IWebElement passwordInputButton = driver.FindElement(By.CssSelector(inputPasswordButtonSelector));
                passwordInputButton.Click();

                driverWait.Until(d => d.FindElement(By.CssSelector(mailBoxSelector)).Displayed);











            }
        }
    }
}

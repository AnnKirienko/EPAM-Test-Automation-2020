using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver.Website
{
   public class DefaultPage
    {
        private IWebDriver driver;
        private WebDriverWait driverWait;
        private string url = @"http://localhost";
        private string sendButtonSelector = "#menT>div>a:nth-child(1)";
        private string nextPageSelector = "#articleText>div.centerRight>h2";

        public DefaultPage(IWebDriver driver, WebDriverWait driverWait)
        {
            this.driver = driver;
            this.driverWait = driverWait;
        }

        public void OpenDefaultPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        private void InputName(string name)
        {
            //
        }

        private void InputPhoneNumber(string number)
        {
            //
        }

        private void InputEmail(string email)
        {
            //
        }

        public void InputData(string name, string number, string email)
        {
            this.InputName(name);
            this.InputPhoneNumber(number);
            this.InputEmail(email);
        }

        public void ChooseOption()
        { }
        private IWebElement FindButton()
        {
            
            IWebElement sendButton = driver.FindElement(By.CssSelector(sendButtonSelector));
            // TODO: check for null
            return sendButton;
        }
        public void SendInvitation()
        {
            


        }


    }
}

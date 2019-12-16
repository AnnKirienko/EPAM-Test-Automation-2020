using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace Calculator
{
    public class CalculatorPage
    {
        const string calculatorPageUrl = "http://calkulyator.ru/";
        readonly Dictionary<char, string> buttonNameToSelector = new Dictionary<char, string>
        { { '1', "#nmr_19 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '2', "#nmr_20 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '3', "#nmr_21 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '4', "#nmr_13 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '5', "#nmr_14 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '6', "#nmr_15 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '7', "#nmr_7 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '8', "#nmr_8 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '9', "#nmr_9 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '0', "#nmr_25 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '.', "#nmr_27 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '+', "#nmr_22 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '-', "#nmr_17 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '*', "#nmr_16 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '=', "#nmr_23 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" },
            { '%', "#nmr_11 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1)" }
        };

        const string resultSelector = "#display";
        const string expressionAndResultSelector = "#disp-tekd";
        IWebElement resultElement;
        IWebElement expressionAndResultElement;

        Dictionary<char, IWebElement> buttonNameToElement = new Dictionary<char, IWebElement>();

        readonly IWebDriver driver;
        readonly WebDriverWait driverWait;

        public CalculatorPage(IWebDriver driver)
        {
            this.driver = driver;

            driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        private void InitializeFields()
        {
            InitializeButtons();
            InitializeResultFields();
        }

        private void InitializeResultFields()
        {
            resultElement = driver.FindElement(By.CssSelector(resultSelector));
            expressionAndResultElement = driver.FindElement(By.CssSelector(expressionAndResultSelector));
        }

        private void InitializeButtons()
        {
            foreach (var item in buttonNameToSelector)
            {
                IWebElement button = driver.FindElement(By.CssSelector(item.Value));

                buttonNameToElement[item.Key] = button;
            }
        }

        public void ClickButtonByName(char buttonName)
        {
            IWebElement button = buttonNameToElement[buttonName];

            button.Click();
        }

        public void ClickButtonByCssSelector(string selectorString)
        {
            By selector = By.CssSelector(selectorString);

            driverWait.Until(d => d.FindElement(selector).Displayed);
            IWebElement button = driver.FindElement(selector);

            button.Click();
        }

        public string GetCurrentResult()
        {
            return resultElement.Text;
        }
        public string GetCurrentExpressionAndResult()
        {
            return expressionAndResultElement.Text;
        }

        public void LoadPage()
        {
            driver.Navigate().GoToUrl(calculatorPageUrl);
            InitializeButtons();
            InitializeResultFields();
        }
    }
}

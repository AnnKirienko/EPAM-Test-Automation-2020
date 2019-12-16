using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace Calculator
{
    public class CalculatorPage
    {
        const string one = "#nmr_19 > table > tbody > tr > td";
        const string two = "#nmr_20 > table > tbody > tr > td";
        const string three= "#nmr_21 > table > tbody > tr > td";
        const string four = "#nmr_13 > table > tbody > tr > td";
        const string five = "#nmr_14 > table > tbody > tr > td";
        const string six = "#nmr_15 > table > tbody > tr > td";
        const string seven = "#nmr_7 > table > tbody > tr > td";
        const string eight = "#nmr_8 > table > tbody > tr > td";
        const string nine = "#nmr_9 > table > tbody > tr > td";
        const string zero = "#nmr_25 > table > tbody > tr > td";
        const string plus = "#nmr_22 > table > tbody > tr > td";
        const string minus = "";
        const string doubleZero = "#nmr_26 > table > tbody > tr > td";
        const string point = "#nmr_27 > table > tbody > tr > td";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        const string = "";
        public void LoadPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--log-level=3");
            IWebDriver driver = new ChromeDriver(options);
            
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                driver.Navigate().GoToUrl("http://calkulyator.ru/");
            
        }

        Dictionary<string, string> buttons = new Dictionary<string, string>
        {
            {"1" ,one},
            {"2", two},
            {"3",three },
            {"4",four },
            {"5",five },
            {"6",six},
            {"7",seven },
            {"8",eight },
            {"9",nine },
            {"0", zero },
            {"+",plus },
            {"-",minus },
            {"*","" },
            {"=","" },
            {"00",doubleZero },
            {".",point },
            {"sqrt","" },
            {"pow","" },
            {"%","" },
            {"/","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
            {"","" },
        };
        
       
    }
}

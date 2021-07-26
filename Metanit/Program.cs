using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Metanit
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                MainPage mainPage = new MainPage(driver, driverWait);
                mainPage.OpenMainPage();
                mainPage.ClickToC_SharpButton();
                CSharpPage cSharpPage = new CSharpPage(driver, driverWait);
                cSharpPage.PrintTextElements();
                Console.WriteLine("End of program!!!!!!");
            }
        }
    }
}

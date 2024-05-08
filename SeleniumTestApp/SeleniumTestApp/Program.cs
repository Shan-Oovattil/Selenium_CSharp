using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Test Case Started....");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement searchEle = driver.FindElement(By.XPath("//div[@class='YacQv']/following-sibling::textarea[@class='gLFyf']"));
            searchEle.SendKeys("Shan");


            IWebElement gSearchEle = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']/descendant::input[@name='btnK']"));

            gSearchEle.Click();

            

            driver.Quit();

            


        }
    }
}

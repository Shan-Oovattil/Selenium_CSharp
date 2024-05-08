using NUnit.Framework;
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
    internal class Sample1
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

        }

        [Test] 
        public void Test() 
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           
            IWebElement emailEle = driver.FindElement(By.Id("email"));
            emailEle.SendKeys("oa.gtalk@gmail.com");
            Thread.Sleep(2000);
            Console.WriteLine("username value is entered");

            IWebElement passwordEle = driver.FindElement(By.Id("pass"));
            passwordEle.SendKeys("Yaash@00007");
            Console.WriteLine("password is entered");

            driver.FindElement(By.XPath("//button[@name='login']")).Click();
            Thread.Sleep(3000);
            Console.WriteLine("login button is clicked");
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}

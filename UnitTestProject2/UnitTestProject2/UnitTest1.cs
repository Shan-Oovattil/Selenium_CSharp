//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject2
{
   
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://shop.demoqa.com/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(45);

            //Get Page Title name and Title length
            string pageTitle = driver.Title.ToString();
            int lenPageTitle = driver.Title.Length;

            //Print Page Title and Title length on the Eclipse Console.
            Console.WriteLine($"PageTitle: {pageTitle}");
            Console.WriteLine($"Page Length: {lenPageTitle}");

            // Get Page URL and verify if it is a correct page opened
            string url = driver.Url;
            Assert.That(url, Is.EqualTo("https://shop.demoqa.com/"), "Navigated to the WRONG-URL");

            // Get Page Source (HTML Source code) and Page Source length
            string pageSource = driver.PageSource;
            int lenPageSource = driver.PageSource.Length;

            // Print Page Length on Eclipse Console.
            //Console.WriteLine($"Page Source:{pageSource}");
            Console.WriteLine($"Length of Page-Source:{lenPageSource}");


            

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

    }
}

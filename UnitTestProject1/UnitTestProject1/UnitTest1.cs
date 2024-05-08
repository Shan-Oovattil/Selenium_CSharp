using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        OpenQA.Selenium.IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]
        [NUnit.Framework.Ignore("this test case")]
        public void Test1_PracticeExercise1()
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
            NUnit.Framework.Assert.That(url, Is.EqualTo("https://shop.demoqa.com/"), "Navigated to the WRONG-URL");

            // Get Page Source (HTML Source code) and Page Source length
            string pageSource = driver.PageSource;
            int lenPageSource = driver.PageSource.Length;

            // Print Page Length on Eclipse Console.
            //Console.WriteLine($"Page Source:{pageSource}");
            Console.WriteLine($"Length of Page-Source:{lenPageSource}");


            NUnit.Framework.Assert.Pass();
        }

        [Test]
        [NUnit.Framework.Ignore("Ignore this test case also")]
        public void Test2_PracticeExercise2()
        {
            /*Launch a new Chrome browser.
            Open ToolsQA Practice Automation Page for Switch Windows: https://demoqa.com/browser-windows/
            Use this statement to click on a New Browser Window button "driver.findElement(By.id("New Browser Window")).click();"
            */

            driver.Navigate().GoToUrl("https://demoqa.com/browser-windows/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds((50));

            driver.FindElement(By.Id("windowButton")).Click();

        }

        [Test]
        [NUnit.Framework.Ignore("Igniore this test case")]
        public void Test3_PracticeExercise3()
        {
            driver.Navigate().GoToUrl("https://www.toolsqa.com/selenium-training/");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[text()='Go To Registration ']")).Click();

            Thread.Sleep(1000);
            driver.Navigate().Back();

            Thread.Sleep(1000);
            driver.Navigate().Forward();

            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("https://www.toolsqa.com/selenium-training/");

            Thread.Sleep(1000);
            driver.Navigate().Refresh();
        }

        [Test]
        public void Test4_ExplicitWait4()
        {
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/about/about_team.htm");

            driver.FindElement(By.XPath("//a[text()=\"Team\"]")).Click();



            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);

            wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("h1")));

            string headerText = driver.FindElement(By.XPath("//h1[text()='Team @ Tutorials Point']")).Text.ToString();
            Console.WriteLine(headerText);

        }


        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }



    }
}

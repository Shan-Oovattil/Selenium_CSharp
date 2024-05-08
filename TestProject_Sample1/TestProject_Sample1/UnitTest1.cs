using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TestProject_Sample1
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            string sTitle = driver.Title;

            //Assert.That(sTitle, Is.EqualTo("Google"), "Title is incorrect");

            Assert.AreEqual(sTitle, "Google", "Not Correct Title");

            //Assert.Pass();
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}
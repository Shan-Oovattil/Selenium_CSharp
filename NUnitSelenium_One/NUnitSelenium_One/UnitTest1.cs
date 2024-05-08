using NUnitSelenium_One.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitSelenium_One
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [Ignore("Ignore this test case")]
        public void Test1()
        {
            //Assert.Pass();

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();

            IWebElement searchElement = driver.FindElement(By.Id("APjFqb"));
            searchElement.SendKeys("Selenium Tutorial");
            searchElement.Click();
            //driver.FindElement(By.XPath("//input[@Value= 'Google Search']")).Click();

            Thread.Sleep(3000);
            driver.Quit();

        }


        [Test]
        [Ignore("Ignore this test case")]
        public void EAWebsiteTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("password");
            driver.FindElement(By.CssSelector(".btn.btn-default")).Submit();
            //driver.FindElement(By.ClassName("btn")).Submit();
        }


        [Test]
        [Ignore("Ignore this test case")]
        public void EAWebsiteTestUsingCustomMethods()
        {
            IWebDriver driver = new ChromeDriver();
            SeleniumCustomMethods.NavigationAndMaximizeWindow(driver, "http://eaapp.somee.com/");

            //SeleniumCustomMethods.Click(driver, By.Id("loginLink"));
            //SeleniumCustomMethods.EnterText(driver, By.Name("UserName"), "admin");
            //SeleniumCustomMethods.EnterText(driver, By.Name("Password"), "password");
            //SeleniumCustomMethods.Submit(driver, By.CssSelector(".btn.btn-default"));

            //driver.FindElement(By.Id("loginLink")).Click();
            //driver.FindElement(By.Name("UserName")).SendKeys("admin");
            //driver.FindElement(By.Name("Password")).SendKeys("password");
            //driver.FindElement(By.CssSelector(".btn.btn-default")).Submit();
            //driver.FindElement(By.ClassName("btn")).Submit();
        }

        [Test]
        [Ignore("Ignore this test case")]
        public void EAWebsiteTestWithPOM()
        {
            IWebDriver driver = new ChromeDriver();
            SeleniumCustomMethods.NavigationAndMaximizeWindow(driver, "http://eaapp.somee.com/");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickLogin();
            loginPage.Login("admin", "password");
        }

        [Test]
        [Ignore("Ignore this test case")]
        public void EAWebsiteTestUsingCustomMethodsUpdated()
        {
            IWebDriver driver = new ChromeDriver();
            SeleniumCustomMethods.NavigationAndMaximizeWindow(driver, "http://eaapp.somee.com/");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickLogin();
            loginPage.Login("admin", "password");

        }



    }
}
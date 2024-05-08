using NUnitSelenium_One.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium_One
{
    [TestFixture("admin", "password")]
    public class NUnitDemo
    {
        private IWebDriver _driver;
        private readonly string username;
        private readonly string password;

        public NUnitDemo(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            SeleniumCustomMethods.NavigationAndMaximizeWindow(_driver, "http://eaapp.somee.com/");
        }

        [Test]
        [Ignore("Ignore this")]
        public void EAWebsiteTestWithPOM()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.ClickLogin();
            loginPage.Login(username, password);
        }

        [Test]
        [Ignore("Ignore this")]
        [TestCase("Chrome", "30.0")]
        public void TestBrowserWithVersion(string browser, string vers)
        {
            Console.WriteLine($"Browser Details are {browser}:{vers}");
        }



        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}

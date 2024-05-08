using NUnitSelenium_One.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NUnitSelenium_One
{
    public class DataDrivenTests
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            SeleniumCustomMethods.NavigationAndMaximizeWindow(_driver, "http://eaapp.somee.com/");
        }

        //[Test]
        //[Category("DataDrivenTest")]
        //public void EAWebsiteWithJSON()
        //{          
        //    LoginPage loginPage = new LoginPage(_driver);
        //    loginPage.ClickLogin();
        //    loginPage.Login(loginModel.UserName, loginModel.Password);
        //}

        [Test]
        [Category("ddt")]
        [TestCaseSource(nameof(LoginJsonDataSource))]       
        public void EAWebsiteTestWithPOMAndJSon(LoginModel loginModel)
        {
            // Arrange
            LoginPage loginPage = new LoginPage(_driver);
            
            // Act
            loginPage.ClickLogin();
            loginPage.Login(loginModel.UserName, loginModel.Password);

            // Assert
            var getLoggedIn = loginPage.IsLoggedIn();
            Assert.IsTrue(getLoggedIn);

        }


        private static IEnumerable<LoginModel> LoginJsonDataSource()
        {
            string jSonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.json");

            var jsonContent = File.ReadAllText(jSonPath);
            var loginModel = JsonSerializer.Deserialize<List<LoginModel>>(jsonContent);

            foreach (var loginData in loginModel)
            {
                yield return loginData;
            }
        }


        //[Test]
        //[Category("ddt")]
        //[TestCaseSource(nameof(Login))]
        //[Ignore("Ignore this case")]
        //public void EAWebsiteTestWithPOM(LoginModel loginModel)
        //{
        //    LoginPage loginPage = new LoginPage(_driver);
        //    loginPage.ClickLogin();
        //    loginPage.Login(loginModel.UserName, loginModel.Password);
        //}               

        //private static IEnumerable<LoginModel> Login()
        //{
        //    yield return new LoginModel()
        //    {
        //        UserName = "admin",
        //        Password = "password"                
        //    };
        //    yield return new LoginModel()
        //    {
        //        UserName = "admin1",
        //        Password = "password"
        //    };
        //    yield return new LoginModel()
        //    {
        //        UserName = "admin2",
        //        Password = "password"
        //    };
        //}
              
        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}

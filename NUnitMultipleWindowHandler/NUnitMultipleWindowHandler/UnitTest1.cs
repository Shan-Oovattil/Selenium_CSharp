using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;

namespace NUnitMultipleWindowHandler
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            //driver.FindElement(By.Id("windowButton")).Click();
            IWebElement ele = driver.FindElement(By.Id("windowButton"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", ele);

            string parentWindowHandle = driver.CurrentWindowHandle;
            

            for(int i = 0; i < 2; i++)
            {
                ele.Click();
            }

            List<string> lstWindowHandles = driver.WindowHandles.ToList();

            foreach(var handle in lstWindowHandles)
            {
                Console.WriteLine(handle.ToString());

                Console.WriteLine($"Switching into: {handle}");
                driver.SwitchTo().Window(handle);
                driver.Navigate().GoToUrl("https://www.google.com");
            }
   
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}
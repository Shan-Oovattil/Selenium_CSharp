using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitDisplayedSelectedChecking
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();

            string title =  driver.Title;
            Console.WriteLine(title);

            IWebElement googleSearchEle = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//following::input[@class='gNO89b']"));
            bool googleSearchButtonDisplayStatus = googleSearchEle.Displayed;
            Console.WriteLine($"Display Status: {googleSearchButtonDisplayStatus}");
            bool googleSearchButtonEnableStatus = googleSearchEle.Enabled;
            Console.WriteLine($"Enable Status: {googleSearchButtonEnableStatus}");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//textarea[@class='gLFyf']")).SendKeys("Selenium");
            googleSearchEle.Click();
        }
    }
}
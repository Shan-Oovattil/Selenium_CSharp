using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace NUnit_AlertHandler
{
    public class Tests
    {
        //private IWebDriver driver;

        //[SetUp]
        //public void Setup()
        //{
        //    driver = new ChromeDriver();
        //    //driver.Navigate().GoToUrl("https://demoqa.com/alerts");
        //    //driver.Manage().Window.Maximize();
        //}

        //[Test]
        //[Ignore("Ignore this test case")]
        //public void TestSimpleAlert()
        //{
        //    driver.FindElement(By.Id("alertButton")).Click();
        //    IAlert alert = driver.SwitchTo().Alert();
        //    alert.Accept();

        //    //Assert.Pass();
        //}

        //[Test]
        //[Ignore("Ignore this test case")]
        //public void TestAlertAfter10Seconds() 
        //{
        //    // timerAlertButton
        //    //IWebElement element = driver.FindElement(By.Id("timerAlertButton"));
        //    //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);

        //    IWebElement ele = driver.FindElement(By.Id("timerAlertButton"));
        //    ele.Click();

        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    //wait.Until(d=> ele.Selected);

        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    if (ele.Selected)
        //    {
        //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //        IAlert alert = driver.SwitchTo().Alert();
        //        alert.Accept();
        //    }
        //    // wait            
        //}


        //[Test]
        //[Ignore("Ignore this")]
        //public void TestConfirmationAlert()
        //{
        //    driver.FindElement(By.Id("confirmButton")).Click();

        //    IAlert alert = driver.SwitchTo().Alert();
        //    alert.Dismiss();
        //}

        //[Test]
        //[Ignore("Ignore this")]
        //public void TestPromptAlert()
        //{
        //    driver.FindElement(By.Id("promtButton")).Click();
        //    IAlert alert = driver.SwitchTo().Alert();
        //    alert.SendKeys("Sagar Elias Jacky");
        //    alert.Accept();
        //    //alert.Dismiss();
        //}

        //[Test]
        //[Ignore("Ignore this")]
        //public void TestSimpleAlertUsingJavaScriptExecutor()
        //{
        //    IWebElement ele = driver.FindElement(By.Id("alertButton"));

        //    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", ele);
            

        //    IAlert alert = driver.SwitchTo().Alert();
        //    alert.Accept();

        //    //SelectElement select = new SelectElement(ele);
        //    //select.SelectByIndex(0);
            
            
        //    //Actions actions = new Actions(driver);
        //    //actions.MoveToElement(ele).Click().Perform();

        //}

        //[Test]
        //public void ActionSample1()
        //{
        //    driver.Navigate().GoToUrl("https://www.browserstack.com/");
        //    driver.Manage().Window.Maximize();
        //    Actions action = new Actions(driver);

        //    // accept-cookie-notification
        //    //IAlert alert = driver.SwitchTo().Alert();
        //    //alert.Dismiss();

        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        //    IWebElement element = driver.FindElement(By.Id("signupModalProductButton"));
        //    action.MoveToElement(element).Click().Perform();

        //    ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,300)");


        //    //using click action method
        //}


        //[TearDown]
        //public void CleanUp() 
        //{
        //    //driver.Quit();
        //}
    
        IWebDriver driver;

        [Test]
        public void ChooseLaptopToPurchase()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.flipkart.com/search?q=laptop&otracker=search&otracker1=search&marketplace=FLIPKART&as-show=on&as=off&sort=relevance");
            driver.Manage().Window.Maximize();

            List<string> lstHandles = driver.WindowHandles.ToList();

            foreach(var handle in lstHandles) 
            {
                Console.WriteLine(handle.ToString());                
            }

            driver.SwitchTo().Window(lstHandles[1]);


        }
             
    
    
    }
}
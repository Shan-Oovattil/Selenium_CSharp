using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitWebTables
{
    public class Tests
    {
        //IWebDriver driver;

        //[SetUp]
        //public void Setup()
        //{
        //    driver = new ChromeDriver();
        //}

        //[Test]
        //[Ignore("Ignore this")]
        //public void TestStaticWebTable()
        //{
        //    driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");
        //    driver.Manage().Window.Maximize();

        //    List<IWebElement> lstOfDatas = driver.FindElements(By.XPath("//table[@id='customers']/tbody/tr/td")).ToList();

        //    foreach (IWebElement data in lstOfDatas)
        //    {
        //        Console.WriteLine(data.Text);
        //    }
        //}

        //[Test]
        //[Ignore("Ignore this")]
        //public void TestDynamicWebTable()
        //{
        //    driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");
        //    driver.Manage().Window.Maximize();

        //    List<IWebElement> lstOfDatas = driver.FindElements(By.XPath("//span[text()='Structure']/following::tbody/tr/th")).ToList();

        //    int countOfStrctures = lstOfDatas.Count();
        //    string actualResult = countOfStrctures.ToString() + " " + "buildings";

        //    IWebElement totalStructures = driver.FindElement(By.XPath("//span[text()='Total']/following::td[1]"));
        //    string expectedResult = totalStructures.Text;

        //    Assert.That(actualResult, Is.EqualTo(expectedResult), "Failed: Values are not Equal");

        //}

        //[Test]
        //public void TestBurjKhalifaHeight()
        //{
        //    // 
        //    // 

        //    driver.Navigate().GoToUrl("https://www.techlistic.com/p/demo-selenium-practice.html");
        //    driver.Manage().Window.Maximize();

        //    IWebElement burjEle = driver.FindElement(By.XPath("//span[text()='Burj Khalifa']"));
        //    bool burjKhalifaDisplayed = burjEle.Displayed;

        //    if (burjKhalifaDisplayed)
        //    {
        //        IWebElement heightOfBurjEle = driver.FindElement(By.XPath("//span[text()='Burj Khalifa']/following::td[3]"));
        //        string heightOfBurjKhalifa = heightOfBurjEle.Text;

        //        Assert.That(heightOfBurjKhalifa, Is.EqualTo("829m"), "Height is not-equal");
        //        Console.WriteLine("SUCCESS");
        //    }
        //    else
        //        Console.WriteLine("Burj Khalifa Data is not Displayed in the Table");

        //}

        //[TearDown]
        //public void CleanUpCode()
        //{
        //    driver.Quit();
        //}





    }
}
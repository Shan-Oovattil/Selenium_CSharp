using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitSelenium_One
{
    public static class SeleniumCustomMethods
    {
        public static void NavigationAndMaximizeWindow(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public static void Click(IWebElement locator)
        {
            locator.Click();
        }

        public static void Submit(IWebElement locator)
        {
            locator.Submit();
        }

        public static void ClickElement(this IWebElement locator)
        {
            locator.Click();
        }

        public static void SubmitElement(this IWebElement locator)
        {
            locator.Submit();
        }

        public static void EnterText(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropdownByText(this IWebElement locator, string text)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
        }

        public static void SelectDropdownByValue(this IWebDriver driver, By locator, string value)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            selectElement.SelectByValue(value);
        }

        public static void SelectDropdownByIndex(this IWebElement locator, int index)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByIndex(index);
        }

        public static void MultiSelectDropdownByText(this IWebElement locator, string[] text)
        {
            SelectElement selectElement = new SelectElement(locator);

            foreach (string s in text)
            {
                selectElement.SelectByText(s);
            }
        }







        //public static void Click(IWebDriver driver, By locator)
        //{
        //    driver.FindElement(locator).Click();
        //}

        //public static void Submit(IWebDriver driver, By locator)
        //{
        //    driver.FindElement(locator).Submit();
        //}

        //public static void EnterText(IWebDriver driver, By locator, string text)
        //{
        //    driver.FindElement(locator).SendKeys(text);
        //}

        //public static void SelectDropdownByText(IWebDriver driver, By locator, string text)
        //{
        //    SelectElement selectElement = new SelectElement(driver.FindElement(locator));
        //    selectElement.SelectByText(text);
        //}

        //public static void SelectDropdownByValue(IWebDriver driver, By locator, string value)
        //{
        //    SelectElement selectElement = new SelectElement(driver.FindElement(locator));
        //    selectElement.SelectByValue(value);
        //}

        //public static void SelectDropdownByIndex(IWebDriver driver, By locator, int index)
        //{
        //    SelectElement selectElement = new SelectElement(driver.FindElement(locator));
        //    selectElement.SelectByIndex(index);
        //}

        //public static void MultiSelectDropdownByText(IWebDriver driver, By locator, string[] text)
        //{
        //    SelectElement selectElement = new SelectElement(driver.FindElement(locator));

        //    foreach (string s in text)
        //    {
        //        selectElement.SelectByText(s);
        //    }
        //}

    }
}

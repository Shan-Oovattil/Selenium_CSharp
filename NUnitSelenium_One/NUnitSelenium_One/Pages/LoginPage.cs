using OpenQA.Selenium;

namespace NUnitSelenium_One.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));
        IWebElement UsernameTxt => driver.FindElement(By.Name("UserName"));
        IWebElement PasswordTxt => driver.FindElement(By.Name("Password"));
        IWebElement LoginBtn => driver.FindElement(By.CssSelector(".btn.btn-default"));
        IWebElement LnkEmployeeDetails => driver.FindElement(By.LinkText("Employee Details"));
        IWebElement LnkManageUsers => driver.FindElement(By.LinkText("Manage Users"));
        IWebElement LnkLogOff => driver.FindElement(By.LinkText("Log off"));


        public void ClickLogin()
        {
            //SeleniumCustomMethods.Click(LoginLink);
            LoginLink.ClickElement();
        }
        public void Login(string username, string password)
        {
            UsernameTxt.EnterText(username);
            PasswordTxt.EnterText(password);
            LoginBtn.SubmitElement();

            //SeleniumCustomMethods.EnterText(UsernameTxt, username);
            //SeleniumCustomMethods.EnterText(PasswordTxt, password);            
            //SeleniumCustomMethods.Submit(LoginBtn);
        }

        public bool IsLoggedIn()
        {
            //return LnkLogOff.Displayed;
            return LnkEmployeeDetails.Displayed;

        }




    }
}

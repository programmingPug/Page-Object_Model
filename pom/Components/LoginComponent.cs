using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace pom.Components
{
    public class LoginComponent
    {
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait;
        private IJavaScriptExecutor jsExecutor;

        public LoginComponent(IWebDriver _webDriver)
        {
            webDriver = _webDriver;
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            jsExecutor = (IJavaScriptExecutor)webDriver;
        }

        public void GoToLogin()
        {
            webDriver.Navigate().GoToUrl("Some Site");
        }

        public void EnterUserCredentials(string username, string password)
        {
            webDriver.FindElement(By.Name("username")).SendKeys(username);
            webDriver.FindElement(By.Name("password")).SendKeys(password);
        }

        public void SubmitLoginForm()
        {
            webDriver.FindElement(By.Name("login")).Click();
        }
    }
}
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace pom.Components
{
    public class LandingComponent
    {
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait;
        private IJavaScriptExecutor jsExecutor;

        public LandingComponent(IWebDriver _webDriver)
        {
            webDriver = _webDriver;
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            jsExecutor = (IJavaScriptExecutor)webDriver;
        }
    }
}
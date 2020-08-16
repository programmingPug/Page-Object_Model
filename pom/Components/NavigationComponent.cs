using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace pom.Components
{
    public class NavigationComponent
    {
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait;

        public NavigationComponent(IWebDriver _webDriver)
        {
            webDriver = _webDriver;
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
        }

        public string GetNavAccountName()
        {
            //Example of getting an account name
            var accountNav = webDriver.FindElement(By.Id("account-nav")).FindElements(By.TagName("span"))[1];
            string accountNavName = accountNav.GetAttribute("innerHTML");

            return (accountNavName);
        }

        public void GoToVideos()
        {
            //Goes to videos page
        }
    }
}

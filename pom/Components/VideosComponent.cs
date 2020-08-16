using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace pom.Components
{
    public class VideosComponent
    {
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait;
        private IJavaScriptExecutor jsExecutor;

        public VideosComponent(IWebDriver _webDriver)
        {
            webDriver = _webDriver;
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            jsExecutor = (IJavaScriptExecutor)webDriver;
        }

        public void SelectVideo()
        {
            webDriverWait.Until(drv => drv.FindElement(By.ClassName("video-loop-video-title")));

            var videos = webDriver.FindElements(By.ClassName("video-loop-video-title"));
            var video = videos[0];
            video.Click();
        }
    }
}
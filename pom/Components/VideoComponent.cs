using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace pom.Components
{
    public class VideoComponent
    {
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait;
        private IJavaScriptExecutor jsExecutor;

        public VideoComponent(IWebDriver _webDriver)
        {
            webDriver = _webDriver;
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            jsExecutor = (IJavaScriptExecutor)webDriver;
        }

        public void PlayVideo()
        {
            //Plays Video
        }

        public void PauseVideo()
        {
            //Pauses Video
        }

        public bool GetVideoPlayState()
        {
            //Get video play sate from player
            return (false);
        }

    }
}
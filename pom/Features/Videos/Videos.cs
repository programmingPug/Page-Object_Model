using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using pom.Components;
using TechTalk.SpecFlow;

namespace pom.Features.Videos
{
    [Binding]
    public class Videos
    {
        private IWebDriver webDriver;
        private LoginComponent loginComponent;
        private NavigationComponent navigationComponent;
        private VideosComponent videosComponent;
        private VideoComponent videoComponent;
        
        [BeforeScenario]
        public void setupTest()
        {
            webDriver = GetWebDriver();

            loginComponent = new LoginComponent(webDriver);
            navigationComponent = new NavigationComponent(webDriver);
            videosComponent = new VideosComponent(webDriver);
            videoComponent = new VideoComponent(webDriver);
        }

        public IWebDriver GetWebDriver()
        {
            /* Yes we could put this into a factory and use DI but KISS for now. */
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");

            IWebDriver ChromeWebDriver = new ChromeDriver(options);
            return ChromeWebDriver;
        }

        [Given(@"I have logged into the application")]
        public void GivenIHaveLoggedIntoTheApplication()
        {
            loginComponent.GoToLogin();
            loginComponent.EnterUserCredentials("", "");
            loginComponent.SubmitLoginForm();
        }

        [Given(@"I have started playing a video")]
        public void AndIHaveStartedPlayingAVideo()
        {
            navigationComponent.GoToVideos();
            videosComponent.SelectVideo();
            videoComponent.PlayVideo();
        }

        [When(@"I press pause")]
        public void WhenIPressPause()
        {
            videoComponent.PauseVideo();
            videoComponent.GetVideoPlayState().Should().Be(true);
        }

        [Then(@"the video should be paused")]
        public void ThenTheVideoShouldBePaused()
        {
            videoComponent.GetVideoPlayState().Should().Be(true);
        }
    }
}
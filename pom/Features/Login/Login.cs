using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using pom.Components;
using TechTalk.SpecFlow;

namespace pom.Features.Login
{
    [Binding]
    public class Login
    {
        private IWebDriver webDriver;
        private LoginComponent loginComponent;
        private NavigationComponent navigationComponent;

        [BeforeScenario]
        public void SetupTest()
        {
            webDriver = GetWebDriver();

            loginComponent = new LoginComponent(webDriver);
            navigationComponent = new NavigationComponent(webDriver);
        }

        public IWebDriver GetWebDriver()
        {
            /* Yes we could put this into a factory and use DI but KISS for now. */
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");

            IWebDriver ChromeWebDriver = new ChromeDriver(options);
            return ChromeWebDriver;
        }

        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            loginComponent.GoToLogin();
        }

        [Given(@"I have entered my credentials")]
        public void AndIHaveEnteredMyCredentials()
        {
            loginComponent.EnterUserCredentials("Information", "Information");
        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            loginComponent.SubmitLoginForm();
        }

        [Then(@"the I have logged into the application")]
        public void ThenTheIHaveLoggedIntoTheApplication()
        {
            navigationComponent.GetNavAccountName().Should().Be("user");
        }
    }
}
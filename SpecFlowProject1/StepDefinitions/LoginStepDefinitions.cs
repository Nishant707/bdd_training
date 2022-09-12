using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Hooks;


namespace SpecFlowAutomationTraining.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        
        [Given(@"I have browser with OrangeHrm Page")]
        public void GivenIHaveBrowserWithOrangeHrmPage()
        {
            Automation.driver = new ChromeDriver();
            Automation.driver.Manage().Window.Maximize();
            Automation.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Automation.driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [When(@"I enter username as '([^']*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            Automation.driver.FindElement(By.Name("username")).SendKeys(username);
        }

        [When(@"I enter password as '([^']*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            Automation.driver.FindElement(By.Name("password")).SendKeys(password);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            Automation.driver.FindElement(By.CssSelector("button[type = 'submit']")).Click();
        }

        [Then(@"I should be navigate to '([^']*)' dashboard screen")]
        public void ThenIShouldBeNavigateToDashboardScreen(string expectedValue)
        {
            Console.WriteLine(expectedValue);
        }
        [Then(@"I should get error message as '([^']*)'")]
        public void ThenIShouldGetErrorMessageAs(string error_message)
        {
            Console.WriteLine(error_message);
        }

    }
}

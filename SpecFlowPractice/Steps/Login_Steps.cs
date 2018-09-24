using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowPractice.Steps
{
    [Binding]
    public class Login_Steps
    {
        IWebDriver driver;
        [Given(@"User is at Home page")]
        public void GivenUserIsAtHomePage()
        {
            driver = new ChromeDriver(@"C:\Users\Vinod Kumar\Documents\Visual Studio 2015\Projects\SpecFlowPractice\packages");
            driver.Url = "http://www.store.demoqa.com";
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"Navigate to Login page")]
        public void GivenNavigateToLoginPage()
        {
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
        }

        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string UserName, string Password)
        {
            driver.FindElement(By.XPath("//input[@id='log']")).SendKeys(UserName);
            driver.FindElement(By.XPath("//input[@id='pwd']")).SendKeys(Password);
        }
        
        [When(@"clicks on login button")]
        public void WhenClicksOnLoginButton()
        {
            driver.FindElement(By.Id("login")).Click();
        }
        
        [When(@"User clicks on logout")]
        public void WhenUserClicksOnLogout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successful LogIn message should display")]
        public void ThenSuccessfulLogInMessageShouldDisplay()
        {
            System.Threading.Thread.Sleep(2000);         
            true.Equals(driver.FindElement(By.XPath("//*[@title='Logout']")).Displayed);
            driver.Close();
        }
        
        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

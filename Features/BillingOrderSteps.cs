using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BDD.Features
{
    [Binding]
    public class BillingOrderSteps
    {
        IWebDriver browser;
        private readonly ScenarioContext scenarioContext;

        public BillingOrderSteps(ScenarioContext scenariocontext)
        {
            this.scenarioContext = scenariocontext;
        }


        [Given(@"Open Billing Order Page")]
        public void GivenOpenBillingOrderPage()
        {
            browser = (IWebDriver)scenarioContext["ChromeDriver"];
            string username = (String)scenarioContext["Username"];
            string Password = (String)scenarioContext["Password"];


           
            browser.Url = "http://www.gmail.com";
           
        }
        
        [When(@"Enter user details")]
        public void WhenEnterUserDetails()
        {
         
            
        }
        
        [When(@"submit user details")]
        public void WhenSubmitUserDetails()
        {
            
        }
        
        [Then(@"Form should be submitted successfully")]
        public void ThenFormShouldBeSubmittedSuccessfully()
        {
            
        }
    }
}

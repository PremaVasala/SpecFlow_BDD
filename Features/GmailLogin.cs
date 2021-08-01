using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD
{
    [Binding]
    class GmailLogin
    {
        IWebDriver browser;
        private readonly ScenarioContext scenarioContext;

        public GmailLogin( ScenarioContext scenariocontext )
        {
            this.scenarioContext = scenariocontext;
        }


        [Given(@"Open google Page")]
          public void GivenOpenGooglePage()
        {
            browser = (IWebDriver)scenarioContext["ChromeDriver"];
            browser.Url = "http://www.gmail.com";
           // browser.TakeScreenshort("");
        }

        [When(@"User Eneters valid Credential")]
        public void WhenuserEnterCredential()
        {

        }
           [Then("Successful Login into account")]
           public void ThenSuccessfullLogin()
            {


            }
        }
    }


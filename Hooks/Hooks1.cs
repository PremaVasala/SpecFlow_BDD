using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public IWebDriver Driver;

        private readonly ScenarioContext _scenarioContext;

        public Hooks1 (ScenarioContext scenarioContext)

        {

            _scenarioContext = scenarioContext;

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();

            _scenarioContext["ChromeDriver"] = Driver; // Keeping at common place
            _scenarioContext["Username"] = "admin";
            _scenarioContext["Password"] = "user";

         //Driver.manage().window.maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}

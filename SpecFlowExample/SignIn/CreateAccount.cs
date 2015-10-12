using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using SpecFlowExample.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowExample.SignIn
{
    [Binding, Scope(Tag = "CreateAccount")] //Limit the usage of these steps to Scenarios and Features with the correct tag
    public sealed class CreateAccount
    {
        #region Variable Declarations
        private FirefoxDriver _driver = (FirefoxDriver)ScenarioContext.Current["driver"];
        #endregion

        [Given(@"I am on the Sign-In page")]
        public void GivenIAmOnTheSignInPage()
        {
            _driver.FindElement(HomePage.SignInLink).Click();
            Assert.True(_driver.FindElement(SignInPage.CreateAnAccount).Displayed);
        }

        [Given(@"I click the Create An Account link")]
        public void GivenIClickTheLink()
        {
            _driver.FindElement(SignInPage.CreateAnAccount).Click();
        }

        [When(@"I fill out the new Account form")]
        public void WhenIFillOutTheNewAccountForm()
        {
            var random = new Random();
            
            _driver.FindElement(CreateAccountPage.FirstName).SendKeys("John");
            _driver.FindElement(CreateAccountPage.LastName).SendKeys("Doe");
            _driver.FindElement(CreateAccountPage.Email).SendKeys("test" + random.Next(999, 9999) +"@test.com");
            _driver.FindElement(CreateAccountPage.CreatePassword).SendKeys("Starbucks01!");
            _driver.FindElement(CreateAccountPage.ZipCode).SendKeys("98144");
        }

        [When(@"I click the Create An Account button")]
        public void WhenIClick()
        {
            _driver.FindElement(CreateAccountPage.CreateAnAccount).Click();
        }

        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            Assert.IsTrue(_driver.FindElementByXPath("//h1[ text() = 'Welcome, John!' ]").Displayed);
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Assert.IsTrue(_driver.FindElementByXPath("//p[ text() = 'You have just created a Starbucks.com Account.' ]").Displayed);
        }

    }
}

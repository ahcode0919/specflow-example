using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace SpecFlowExample.Helpers
{
    /// <summary>
    /// Since these have no scope defined they are usable project wide. This is useful for common actions like clicking simple links
    /// </summary>
    [Binding]
    public sealed class GlobalSteps
    {
        #region Variable Declarations
        private FirefoxDriver driver = (FirefoxDriver)ScenarioContext.Current["driver"];
        #endregion

        [When("I click the button with the text '(.*)'")]
        public void WhenIClickLinkWithText(string text)
        {
            //IWebElement element = driver.FindElementByLinkText(text);
            //Or by Xpath
            IWebElement element = driver.FindElementByXPath("//button[ text() = '" + text + "']");

            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Click();
            actions.Perform();
        }
    }
}

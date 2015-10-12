using System;
using System.Linq;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace SpecFlowExample
{
    [Binding]
    public class SpecFlowHooks
    {
        private static FirefoxDriver _driver;
        private static DesiredCapabilities _capabilities;
        private const string BaseUrl = "http://www.starbucks.com";

        public SpecFlowHooks()
        {
            //capabilities = Capabilites.GetTestDriverCapabilities();
        }

        /// <summary>
        /// Runs before each feature file. Can be useful to setup test conditions for certain features
        /// </summary>
        [BeforeFeature]
        public static void BeforeFeature()
        {
            string[] tags = FeatureContext.Current.FeatureInfo.Tags;

            //if (tags.Contains("Clean"))
            //{
            //    //Custom code here... Setup Database.. Navigate to specific url... Clear cache etc.
            //}
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var tags = FeatureContext.Current.FeatureInfo.Tags;

            if (_driver == null)
            {
                _driver = new FirefoxDriver();
            }
            else if (tags.Contains("Clean"))
            {
                _driver = new FirefoxDriver();
                _driver.Manage().Cookies.DeleteAllCookies();
            }

            _driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 15));
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(BaseUrl);

            ScenarioContext.Current["driver"] = _driver;
            ScenarioContext.Current["url"] = BaseUrl;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (FeatureContext.Current.FeatureInfo.Tags.Contains("Clean"))
            {
                try
                {
                    _driver.Quit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
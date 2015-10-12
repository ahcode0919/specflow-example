using OpenQA.Selenium.Remote;

namespace SpecFlowExample.Helpers
{
    class Capabilites
    {
        public static DesiredCapabilities GetDriverCapabilities()
        {
            var capabilities = new DesiredCapabilities();

            //Your custom capabilities here...

            return capabilities;
        }
    }
}

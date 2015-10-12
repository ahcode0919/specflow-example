using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowExample.Pages
{
    static class HomePage
    {
        private static By _signInLink = By.Id("signIn");
        
        public static By SignInLink { get { return _signInLink; } }
    }
}

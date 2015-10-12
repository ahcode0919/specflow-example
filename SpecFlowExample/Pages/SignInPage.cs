using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowExample.Pages
{
    static class SignInPage
    {
        private static By _createAnAccount = By.Id("AT_SignIn_CreateAcctButton");

        public static By CreateAnAccount { get { return _createAnAccount; } }
    }
}

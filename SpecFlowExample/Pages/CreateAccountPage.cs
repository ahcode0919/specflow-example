using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowExample.Pages
{
    static class CreateAccountPage
    {
        private static By _firstName = By.XPath("//label[ contains( text() , 'First Name')]/../input");
        private static By _lastName = By.XPath("//label[ contains( text() , 'Last Name')]/../input");
        private static By _email = By.XPath("//label[ contains( text() , 'Email')]/../input");
        private static By _createPassword = By.XPath("//label[ contains( text() , 'Create Password')]/../div/input");
        private static By _zipCode = By.Id("Address_PostalCode");
        private static By _createAnAccount = By.XPath("//button[ text() = 'Create An Account' ]");

        public static By FirstName { get { return _firstName; } }
        public static By LastName { get { return _lastName; } }
        public static By Email { get { return _email; } }
        public static By CreatePassword { get { return _createPassword; } }
        public static By ZipCode { get { return _zipCode; } }
        public static By CreateAnAccount { get { return _createAnAccount; } }
    }
}

using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Newtonsoft.Json.Linq;
using OrangeHRM_Project.utilities;
using OrangeHRM_Project.utilities.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project.test
{
    internal class Login_Test : Login
    {
        Login login;
        
        [SetUp]
        public void beforeLogin()
        {

         login = new Login(); //Constructor

        }

        [Test]
        [TestCaseSource("loginTestData")]
        public void testLogin(String userName, String Password)
        {
            //Login
           
            // Constructor
            login.performLogin(userName, Password);

        }


        public static IEnumerable<TestCaseData> loginTestData()
        {
            yield return new TestCaseData(readJson("username"), readJson("password"));
            yield return  new TestCaseData(readJson("username1"), readJson("password1"));
            yield return new TestCaseData(readJson("username2"), readJson("password2"));

        }

 


      /*  [TearDown]
        public void tearDown()
        {
            //Browser Close
            closeBrowser();
        }*/

    }
}

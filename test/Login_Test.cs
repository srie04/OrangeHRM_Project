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
    internal class Login_Test
    {
       

        [Test]
    //    [TestCaseSource("loginTestData")]
        public void testLogin()
        {
           
            //Login
            Login login = new Login();
            // Constructor
            login.performLogin("Admin", "admin123");

        }


      /*  public static IEnumerable<TestCaseData> loginTestData()
        {
            yield return new TestCaseData(readJson("username"), readJson("password"));
            yield return  new TestCaseData(readJson("username1"), readJson("password1"));
            yield return new TestCaseData(readJson("username2"), readJson("password2"));

        }*/




       /* [TearDown]
        public void tearDown()
        {
            //Browser Close
            closeBrowser();
        }*/

    }
}

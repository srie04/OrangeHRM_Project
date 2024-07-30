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
        [TestCaseSource("loginTestData")]
        public void testLogin(String username, String password)
        {
           
            //Login
            Login login = new Login();
            // Constructor
            login.performLogin(username, password);

        }


        public static IEnumerable<TestCaseData> loginTestData()
        {
            yield return new TestCaseData(BaseClass.readJson("username"), BaseClass.readJson("password"));
            yield return  new TestCaseData(BaseClass.readJson("username1"), BaseClass.readJson("password1"));
            yield return new TestCaseData(BaseClass.readJson("username2"), BaseClass.readJson("password2"));

        }




       /* [TearDown]
        public void tearDown()
        {
            //Browser Close
            closeBrowser();
        }*/

    }
}

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
    //[Parallelizable(ParallelScope.Self)]
    internal class Login_Test : BaseClass
    {
       

        [Test]
        [TestCaseSource("loginTestData")]
       // [Parallelizable(ParallelScope.All)]
        public void testLogin(String username, String password)
        {
           
            //Login
            Login login = new Login();
            // Constructor
            login.performLogin(username, password);

        }


        public static IEnumerable<TestCaseData> loginTestData()

        {
            String[] cred =  BaseClass.readExcel("Admin");
            yield return new TestCaseData(cred[0], cred[1]);
            //yield return  new TestCaseData(BaseClass.readJson("username1"), BaseClass.readJson("password1"));
            //yield return new TestCaseData(BaseClass.readJson("username2"), BaseClass.readJson("password2"));

        }




      

    }
}

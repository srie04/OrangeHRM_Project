using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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
            //Openbrowser

          
            
             login = new Login();

        }

        [Test]
        public void testLogin()
        {
            //Login
           
            // Constructor
            login.performLogin();

        }

      /*  [TearDown]
        public void tearDown()
        {
            //Browser Close
            closeBrowser();
        }*/

    }
}

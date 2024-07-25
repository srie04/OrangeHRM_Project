using OrangeHRM_Project.utilities.pages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project.test
{
    internal class Admin_Users_Test : Admin_Users
    {
        [SetUp]
        public void setup()
        {
            Login login = new Login(); //Openbrowser, 

            login.performLogin("Admin", "admin123"); //Login Complete
        }
        
        [Test]
        public void Test1()
        {
            Admin_Users admin_Users = new Admin_Users();
            admin_Users.addUser();

        }

        
    }
}

using OrangeHRM_Project.utilities;
using OrangeHRM_Project.utilities.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project.test
{
    internal class Admin_Job_Titles_Test
    {
        [SetUp]
        public void setup()
        {
            Login login = new Login();
            login.performLogin("Admin", "admin123");

        }

        [Test]

        public void jobTitletest()
        {
            Admin_Job_Title job = new Admin_Job_Title();

            job.addjobtitle();
        }

        [TearDown]

        public void tearDown()
        {

            BaseClass.closeBrowser();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrangeHRM_Project.utilities.pages;
using OrangeHRM_Project.utilities;

namespace OrangeHRM_Project.test
{
    internal class PIM_Configuration_Fields_Test
    {

        [SetUp]

        public void setup()
        {
            Login login = new Login();
            login.performLogin("Admin", "admin123");

        }

        [Test]
        public void testFields()
        {
            PIM_Configuration_Fields pim = new PIM_Configuration_Fields();
            //pim.addField();
            //pim.deleteField();
        }

        [TearDown]
        public void tearDown()
        {
           BaseClass.closeBrowser();
        }
    }
}

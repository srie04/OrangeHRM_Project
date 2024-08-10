using OrangeHRM_Project.utilities;
using OrangeHRM_Project.utilities.pages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project.test
{
   // [Parallelizable(ParallelScope.Self)]
    internal class Admin_Users_Test : BaseClass
    {

          [Test, Category("Admin")]
        //    [Parallelizable(ParallelScope.Self)]
        public void Test1()
        {
            Admin_Users admin_Users = new Admin_Users();
            admin_Users.addUser();

            admin_Users.deleteUser();
        }


        [Test] 
        public void Test2() 
        {
            BaseClass.Sample();
        
        }
        
    }
}

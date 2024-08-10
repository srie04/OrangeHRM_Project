using OrangeHRM_Project.utilities;
using OrangeHRM_Project.utilities.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project.test
{
  //  [Parallelizable(ParallelScope.Self)]
    internal class Admin_Job_Title_Test : BaseClass
    {
       

        [Test, Category("Admin")]

        public void jobTitletest()
        {
            Admin_Job_Title job = new Admin_Job_Title();

            job.addjobtitle();
            job.deleteuser();
        }

      

    }
}
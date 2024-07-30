using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project.utilities.pages
{
    internal class Admin_Job_Title : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//span[text()='Admin']/..")]
        private IWebElement admin;
        [FindsBy(How = How.XPath, Using = "//span[text()='Job ']")]
        private IWebElement job;
        [FindsBy(How = How.XPath, Using = "//li/a[text()='Job Titles']")]
        private IWebElement title;
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-layout-context']/div/div/div/div/button")]
        private IWebElement button;
        [FindsBy(How = How.XPath, Using = "//h6[text()='Job Titles']")]
        private IWebElement titlss;
        //div[@class='oxd-layout-context']/div/div/div/div/button
        //h6[text()='Job Titles']
        public Admin_Job_Title()
        {
            PageFactory.InitElements(driver, this);
        }

        public void addjobtitle()
        {
            admin.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(job));
            job.Click();
            title.Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(titlss));
            //Thread.Sleep(4000);
            button.Click();
        }

        public void cancel()
        {
            closeBrowser();
        }
    }
}


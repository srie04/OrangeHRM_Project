using InputSimulatorEx;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        [FindsBy(How = How.XPath, Using = "//form/div/div/div/input")]
        private IWebElement inputtitle;
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Type description here']")]
        private IWebElement description;
        [FindsBy(How = How.ClassName, Using = "oxd-file-button")]
        private IWebElement browswer;
        [FindsBy(How = How.CssSelector, Using = "textarea[placeholder='Add note']")]
        private IWebElement notes;
        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement save;
        [FindsBy(How = How.XPath, Using = "//div[text()='developer']/../../div/div/div")]
        private IWebElement checkbox;

        [FindsBy(How = How.XPath, Using = "(//div[text()='developer']/../following-sibling::div/following-sibling::div/div/button)[1]")]
        private IWebElement delete;
        //div[@class='oxd-layout-context']/div/div/div/div/button
        //h6[text()='Job Titles']
        public Admin_Job_Title()
        {
            PageFactory.InitElements(driver.Value, this);
        }

        public void addjobtitle()
        {
            admin.Click();
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(job));
            job.Click();
            title.Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(titlss));
            //Thread.Sleep(4000);
            button.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(inputtitle));
            //Thread.Sleep(5000);
            inputtitle.Click();
            inputtitle.SendKeys("developer");

            description.Click();
            description.SendKeys("i have 5 years of experience in devlopment.");

           /* browswer.Click();

            Thread.Sleep(3000);



            // IJavaScriptExecutor

            string filelocation = "C:\\Users\\mathu\\Pictures\\Screenshots\\madhu.png";

            InputSimulator input = new InputSimulator();
            input.Keyboard.TextEntry(filelocation);

            Thread.Sleep(2000);

            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.RETURN);
*/
            scroll(save);

            notes.Click();
            notes.SendKeys("Programming Languages: Proficiency in languages relevant to the job (e.g., JavaScript, TypeScript, Python, Java, etc.).");

            save.Click();
        }

        public void deleteuser()
        {
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(checkbox));

            scroll(delete);
            Actions action = new Actions(driver.Value);
            action.MoveToElement(checkbox).Click().Perform();


            //checkbox.Click();

            // Thread.Sleep(3000);

            delete.Click();

            Thread.Sleep(3000);

            driver.Value.FindElement(By.XPath("//button[normalize-space()='Yes, Delete']")).Click();
        }
        //public void cancel()
        //{
        //    closeBrowser();
        //}
    }
}


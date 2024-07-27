using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputSimulatorEx;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM_Project.utilities.pages
{
    internal class Admin_Users : BaseClass
    {
       
        [FindsBy(How = How.XPath, Using = "//span[text()='Admin']/..")]
        private IWebElement admin;

        //button[normalize-space()='Add']
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Add']")]
        private IWebElement addBtn;

        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-wrapper']/div/div)[1]")]
        private IWebElement userRoleTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Type for hints...']")]
        private IWebElement employeeNameTextBox;

        //div[contains(text(),'-- Select --')]
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-wrapper']/div/div[text()='-- Select --']")]
        private IWebElement statusdropdown;

        //input[@class='oxd-input oxd-input--focus']

        [FindsBy(How = How.XPath, Using = "(//div/input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userNameTextBox;

        [FindsBy(How = How.XPath, Using = "(//div/input[@type='password'])")]
        private IWebElement passwordTextBox;

        [FindsBy(How = How.XPath, Using = "(//div/input[@type='password'])[2]")]
        private IWebElement confirmPasswordBox;

        //button[@type='submit']
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement saveBtn;

        //span[text()='Strong ']
        [FindsBy(How = How.XPath, Using = "//span[text()='Strong ']")]
        private IWebElement passwordStrength;



        public Admin_Users()
        {
            
            PageFactory.InitElements(driver,this);
        }

        public void addUser()
        {
            admin.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(addBtn));
            addBtn.Click();
            Thread.Sleep(2000);
            userRoleTextBox.Click();
            InputSimulator input = new InputSimulator();
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.DOWN);
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.DOWN);
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.RETURN);
            employeeNameTextBox.Click();
            input.Keyboard.TextEntry("A");
            Thread.Sleep(8000);
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.DOWN);
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.RETURN);
            Thread.Sleep(2000);
            statusdropdown.Click();
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.DOWN);
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.RETURN);

            userNameTextBox.SendKeys("Sridhar");
            passwordTextBox.SendKeys("Abcdefghijkl1");
           
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(passwordStrength, "Strong"));
            confirmPasswordBox.SendKeys("Abcdefghijkl1");

            saveBtn.Click();




        }

        public void deleteUser()
        {

        }

    }
}

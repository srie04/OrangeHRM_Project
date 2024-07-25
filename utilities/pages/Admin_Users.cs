using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputSimulatorEx;

namespace OrangeHRM_Project.utilities.pages
{
    internal class Admin_Users : Login
    {

        [FindsBy(How = How.XPath, Using = "//span[text()='Admin']")]
        private IWebElement admin;

        //button[normalize-space()='Add']
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Add']")]
        private IWebElement addBtn;

        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-text oxd-select-text--focus']//div[@class='oxd-select-text-input'][normalize-space()='-- Select --']")]
        private IWebElement userRoleTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Type for hints...']")]
        private IWebElement employeeNameTextBox;

        //div[contains(text(),'-- Select --')]
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'-- Select --')]")]
        private IWebElement statusdropdown;

        //input[@class='oxd-input oxd-input--focus']

        [FindsBy(How = How.XPath, Using = "(//div/input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userNameTextBox;

        [FindsBy(How = How.XPath, Using = "(//div/input[@class='oxd-input oxd-input--active'])[3]")]
        private IWebElement passwordTextBox;

        [FindsBy(How = How.XPath, Using = "(//div/input[@class='oxd-input oxd-input--active'])[4]")]
        private IWebElement confirmPasswordBox;

        //button[@type='submit']
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement saveBtn;

        public Admin_Users()
        {
           
            PageFactory.InitElements(driver,this);
        }

        public void addUser()
        {
            admin.Click();
            addBtn.Click();
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
            statusdropdown.Click();
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.DOWN);
            input.Keyboard.KeyPress(InputSimulatorEx.Native.VirtualKeyCode.RETURN);

            userNameTextBox.SendKeys("Sridhar");
            passwordTextBox.SendKeys("Abcdefghijkl1");
            confirmPasswordBox.SendKeys("Abcdefghijkl1");

            saveBtn.Click();




        }


    }
}

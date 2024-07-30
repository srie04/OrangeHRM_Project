using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project.utilities.pages
{
    internal class PIM_Configuration_CustomFields : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Add']")]
        private IWebElement addBtn;

        [FindsBy(How = How.XPath, Using = "(//div/input)[2]")]
        private IWebElement fieldTextBox;

        [FindsBy(How = How.CssSelector, Using = ".oxd-select-text--after")]
        private IWebElement screenDropdownBtn;

        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text--after'])[2]")]
        private IWebElement typeDropdownBtn;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Add']")]
        private IWebElement addBtn;

    }
}

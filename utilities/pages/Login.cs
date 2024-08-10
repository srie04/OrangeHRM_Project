using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;
using OrangeHRM_Project.utilities;

namespace OrangeHRM_Project.utilities.pages
{
    internal class Login : BaseClass
    {
        
        //openBroswer > BaseClass
        //PageFactory
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement usernameBox;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordBox;

        [FindsBy(How =How.TagName, Using = "button")]
        private IWebElement loginButton;

        public Login()
        {

            //Initialize the webelements with the driver
            
            openBrowser();
           
            PageFactory.InitElements(BaseClass.driver.Value, this);
            
        }

        //Perform login
        public void performLogin(String username, String Password)

        {
         
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("username")));
            usernameBox.SendKeys(username);
            passwordBox.SendKeys(Password);
            loginButton.Click();
            wait = new WebDriverWait(driver.Value,TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//img[@alt='client brand banner']")));

        }

        //Close browser > BaseClass
    }
}

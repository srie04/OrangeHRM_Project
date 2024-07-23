using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;

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
             openBrowser();
            //Initialize the webelements with the driver
           
           // openBrowser();
            PageFactory.InitElements(driver, this);
        }

        //Perform login
        public void performLogin(String username, String Password)

        {
          
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("username")));
            usernameBox.SendKeys(username);
            passwordBox.SendKeys(Password);
          //  loginButton.Click();

        }

        //Close browser > BaseClass
    }
}

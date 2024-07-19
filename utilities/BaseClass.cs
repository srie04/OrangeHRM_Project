using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace OrangeHRM_Project.utilities
{
    internal class BaseClass
    {
       public static IWebDriver driver;
        public static WebDriverWait wait; 

        //Open broswer
        
        public void openBrowser() //Chrome, Firefox, edge
        {

            String browserName = ConfigurationManager.AppSettings["browser"];
         //  String browserName = "chrome";

            switch (browserName)
            {
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                     driver = new ChromeDriver();
                    break;

                case "firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;

            }
            driver.Manage().Window.Maximize();
            String url =  ConfigurationManager.AppSettings["url"];
            driver.Url = url;

        }


        public static void closeBrowser()
        {
            driver.Quit();
        }
        //Close browser
    }
}

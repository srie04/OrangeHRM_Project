﻿using Newtonsoft.Json.Linq;
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
     //   public static WebDriverWait wait; 

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

        //This method is to Read the testdata from Json File
        //Whoever want to access the data from Json file use this method and pass
        //the Json key in method parameter

        public static String readJson(String token)
        {
            String jsonString = File.ReadAllText("testdata/login.json");

            JToken jsonObject = JToken.Parse(jsonString);

            String value = jsonObject.SelectToken(token).Value<String>();

            return value;
        }

        public static void closeBrowser()
        {
            driver.Quit();
        }
       

        public void scroll(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OrangeHRM_Project.utilities.pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports.Model;
using System.ComponentModel;
using OfficeOpenXml;


using System.Security.Cryptography.Pkcs;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace OrangeHRM_Project.utilities
{
    internal class BaseClass
    {
        // public static IWebDriver driver;

       public  ExtentReports extent;
       public ExtentTest test;
       public static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        //   public static WebDriverWait wait; 

        //Open broswer

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            //Create One Extent Report

           string workingDirectory = Environment.CurrentDirectory; //BaseClass Path
           string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; //Project Path

           string reportPath = projectDirectory + "//index.html";

            //ExtentSparkReporter > ExtentReports

            ExtentSparkReporter htmlReport = new ExtentSparkReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReport);
            

        }

        [OneTimeTearDown]
        public void OneTimeTearDown() 
        {
            driver.Value.Dispose();
        }

        [SetUp]
        public void Setup()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.MethodName);
            Login login = new Login();
            login.performLogin("Admin", "admin123");

        }

        [TearDown]
        public void Teardown()
        {
           var status = TestContext.CurrentContext.Result.Outcome.Status; //Pass/Fail
            var stack = TestContext.CurrentContext.Result.StackTrace; // Console log
           
            if (status == TestStatus.Passed)
            {
                test.Pass("Test Passed Successfully");
            }
            else if (status == TestStatus.Failed) 
            {
                test.Fail("Test failed", CaptureScreenShot());
                test.Log(Status.Fail,  stack);
            }
            extent.Flush();

            driver.Value.Quit();
        }

        public Media CaptureScreenShot()
        {
            ITakesScreenshot ss = (ITakesScreenshot)driver.Value;
            var screenshot = ss.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot,"img.png").Build();
        }

        public void openBrowser() //Chrome, Firefox, edge
        {

            String browserName = ConfigurationManager.AppSettings["browser"];
         //  String browserName = "chrome";

            switch (browserName)
            {
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); 
                     driver.Value = new ChromeDriver();
                    break;

                case "firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver.Value = new FirefoxDriver();
                    break;

                case "edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver.Value = new EdgeDriver();
                    break;

            }
            driver.Value.Manage().Window.Maximize();
            String url =  ConfigurationManager.AppSettings["url"];
            driver.Value.Url = url;

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
            driver.Value.Quit();
        }
       

        public void scroll(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver.Value;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void Sample()
        {
            driver.Value.Url = "https:///www.google.co.in/";
        }

       static String usernameExcel;
       static String passwordExcel;
       static String[] credentials = new String[2];



        public static String[] readExcel(String getUser)
        {
            string location = "C:\\Users\\Sridhar.Elumalai\\OneDrive - VALGENESIS INDIA PRIVATE LIMITED\\Desktop\\TestExcel.xlsx";

            FileInfo fi = new FileInfo(location);

            //  ExcelPackage.LicenseContext = NonCommercial;

            ExcelPackage package = new ExcelPackage(fi);

            //Workbook > Excel

            using ExcelWorkbook workbook = package.Workbook;

            var worksheet = workbook.Worksheets["Sheet1"];

            int rowCount = worksheet.Dimension.End.Row; //4

            int colCount = worksheet.Dimension.End.Column; //3



            for (int row = 1; row <= rowCount; row++)
            {
                var cellValue = "";

                for (int col = 1; col <= colCount; col++)
                {
                    cellValue = worksheet.Cells[row, col].Text;

                    if (cellValue == getUser)
                    {
                        credentials[0] = cellValue;
                        var cellValue2 = worksheet.Cells[row, col + 1].Text;
                        credentials[1] = cellValue2;
                        break;
                    }
                }

                if (cellValue == "Madhu")
                {
                    break;
                }
            }

           

            return credentials;
           

        }
    }
    }


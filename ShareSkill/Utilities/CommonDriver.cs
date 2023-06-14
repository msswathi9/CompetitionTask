using DocumentFormat.OpenXml.Bibliography;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V110.Browser;
using SeleniumExtras.PageObjects;
using ShareSkill.Pages;
using ShareSkill.Utilities.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ShareSkill.Utilities
{
    public class CommonDriver
    {

        public static IWebDriver driver;
        protected Browser Browser;
        [SetUp]
        public void LoginSteps()
        {
            ExtentReporting.CreateTest(TestContext.CurrentContext.Test.MethodName);

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            Browser = new Browser(driver);

            var loginpage = new LoginPage();
            //Console.WriteLine("We are just before PageFactory Init");
            PageFactory.InitElements(driver, loginpage);
            //Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"home\"]/div/div/div[1]/div/a");
            loginpage.signInButton.Click();

           ExcelLib.PopulateInCollection("C:\\Users\\msswa\\OneDrive\\Desktop\\TestData.xlsx","Sheet1");
           // ExcelLib.PopulateInCollection(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\DataFiles\Loginpage.xlsx");



            loginpage.userTextBox.SendKeys(ExcelLib.ReadData(2, "Column1"));
            loginpage.passwordTestBox.SendKeys(ExcelLib.ReadData(2, "Column2"));
            Wait.WaitToBeVisible(driver, "XPath", 5, "/html/body/div[2]/div/div/div[1]/div/div[4]/button");           
            loginpage.loginButton.Click();




        }
        [TearDown]

        public void DriverQuit()
        {

            EndTest();
            ExtentReporting.EndReporting();
            driver.Quit();
        }
        private void EndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    ExtentReporting.LogFail($"Test has failed{message}");
                    break;

                case TestStatus.Skipped:
                    ExtentReporting.LogInfo($"Test skipped {message}");
                    break;
                default:
                    break;
            }

            ExtentReporting.LogScreenShot("Ending test", Browser.GetScreenShot());
        }
    }
}

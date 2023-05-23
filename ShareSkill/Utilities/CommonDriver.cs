using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using ShareSkill.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareSkill.Utilities
{
    public class CommonDriver
    {

        public IWebDriver driver { get; set; }
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //var loginpage = new LoginPage();
            ////Console.WriteLine("We are just before PageFactory Init");
            //PageFactory.InitElements(driver, loginpage);
            //Thread.Sleep(2000);
            //loginpage.signInButton.Click();

            //ExcelDataReader.PopulateInCollection("C:\\Users\\msswa\\OneDrive\\Desktop\\TestData.xlsx");



            //loginpage.userTextBox.SendKeys(ExcelDataReader.ReadData(2, "Column1"));
            //loginpage.passwordTestBox.SendKeys(ExcelDataReader.ReadData(2, "Column2"));
            //loginpage.loginButton.Click();


        }
        
    }
}

using AutoIt;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ShareSkill.Pages;
using ShareSkill.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;




namespace ShareSkill.Tests
{
    [TestFixture]
    [Parallelizable]
    
    public class ShareSkillTests : CommonDriver
    {
       

        [Test, Order (1), Description("checked if user able to create share skill record")]
        public void CreateShareskillTests()
        {
            var loginpage = new LoginPage();
            //Console.WriteLine("We are just before PageFactory Init");
            PageFactory.InitElements(driver, loginpage);
            Thread.Sleep(2000);
            //Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);
            loginpage.signInButton.Click();

            ExcelDataReader.PopulateInCollection("C:\\Users\\msswa\\OneDrive\\Desktop\\TestData.xlsx");



            loginpage.userTextBox.SendKeys(ExcelDataReader.ReadData(2, "Column1"));
            loginpage.passwordTestBox.SendKeys(ExcelDataReader.ReadData(2, "Column2"));
            loginpage.loginButton.Click();

            var homepage = new HomePage();
            PageFactory.InitElements(driver, homepage);

            Thread.Sleep(4000);
            homepage.shareSkillPage.Click();


            var shareskillpage = new ShareSkillPage();
            PageFactory.InitElements(driver, shareskillpage);   
            Thread.Sleep(2000);
            shareskillpage.titleTextbox.SendKeys(ExcelDataReader.ReadData(3, "Column2"));
            //shareskillpage.titleTextbox.SendKeys("Mrs");
            shareskillpage.descriptionTextbox.SendKeys(ExcelDataReader.ReadData(4,"Column2"));
            //shareskillpage.descriptionTextbox.SendKeys("Software Testing");
            shareskillpage.categoryDropdownbox.Click();
            shareskillpage.selectCategory.Click();
            shareskillpage.subcategoryDropdownbox.Click();
            shareskillpage.selectSubcategory.Click();
            shareskillpage.tagesTextBox.SendKeys(ExcelDataReader.ReadData(5,"Column2"));
            //shareskillpage.tagesTextBox.SendKeys("Testing");
            shareskillpage.tagesTextBox.SendKeys(Keys.Enter);
            shareskillpage.selectHourlyServiceType.Click();
            shareskillpage.selectLocatiotypeOnSite.Click();
            shareskillpage.startDate.SendKeys(ExcelDataReader.ReadData(6,"Column2"));
            //shareskillpage.startDate.SendKeys("30/05/2023");
            shareskillpage.endDate.SendKeys(ExcelDataReader.ReadData(7,"Column2"));
            shareskillpage.endDate.SendKeys("5/06/2023");
            shareskillpage.selecteMonday.Click();
            shareskillpage.mondayStartTime.SendKeys(ExcelDataReader.ReadData(9, "Column2"));
            shareskillpage.mondayEndTime.SendKeys(ExcelDataReader.ReadData(9, "Column3"));
            shareskillpage.tradeSkillCredit.Click();
            //shareskillpage.skillExchange.SendKeys("Software");
            shareskillpage.skillExchange.SendKeys(ExcelDataReader.ReadData(8, "Column2"));
            shareskillpage.skillExchange.SendKeys(Keys.Enter);
            shareskillpage.workSamples.Click();
            //shareskillpage.titleTextbox.SendKeys(ExcelDataReader.ReadData(3, "Column2"));
            // shareskillpage.descriptionTextbox.SendKeys(ExcelDataReader.ReadData(4,"Column2"));
            //shareskillpage.tagesTextBox.SendKeys(ExcelDataReader.ReadData(5,"Column2"));
            //shareskillpage.startDate.SendKeys(ExcelDataReader.ReadData(6,"Column2"));
            //shareskillpage.endDate.SendKeys(ExcelDataReader.ReadData(7,"Column2"));
            //AutoItX3 AutoIt = new AutoItX3();
            //AutoIt.Initializer(driver, shareskillpage);
            //AutoIt.winActivate("workSamples");
            //AutoIt.Send("C:\\Users\\msswa\\OneDrive\\Desktop\\Industry connect record files\\Work Samples\\Integration_Testing.jpg");
            //AutoIt.Click();
            //Thread.Sleep(6000);
            //Process.Start("C:\\Users\\msswa\\OneDrive\\Desktop\\Work Samples\\FileUploadAutoit.exe");
            //Thread.Sleep(5000);
            //shareskillpage.active.Click();
            Thread.Sleep(3000);
            AutoItX.ControlFocus("Open", "", "Edit1");
            Thread.Sleep(3000);
            AutoItX.ControlSetText("Open", "", "Edit1", "C:\\Users\\msswa\\OneDrive\\Desktop\\Work Samples\\File1.txt");
            Thread.Sleep(2000);
            AutoItX.ControlClick("Open", "", "Button1");

            shareskillpage.saveButton.Click();
            Thread.Sleep(3000);
            
           // homepage.manageListingsPage.Click();

            Thread.Sleep(2000);
            string Actualcategory = shareskillpage.category.Text;
            Assert.That(Actualcategory == "Digital Marketing", "Actual category does not match with excepted category");
         
        }
        [TearDown]
        public void PageQuit()
        {
            driver.Quit();
        }


    }
}

//namespace ShareSkill
//{
//    class ExcelDataReader
//    {
//        internal static string ReadData(int v1, string v2)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
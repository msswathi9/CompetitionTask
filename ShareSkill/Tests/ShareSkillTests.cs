using AutoIt;
using AventStack.ExtentReports;
using ExcelDataReader;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ShareSkill.Pages;
using ShareSkill.Utilities;
using ShareSkill.Utilities.Reports;
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
       

        [Test, Order (1), Description("check if user able to create share skill record")]
        public void CreateShareskillTests()
        {
           ExtentReporting.LogInfo($"CreateShareskillTests");

            var homepage = new HomePage();
            PageFactory.InitElements(driver, homepage);

           // Thread.Sleep(4000);
            Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a");
            homepage.shareSkillPage.Click();


            var shareskillpage = new ShareSkillPage();
            PageFactory.InitElements(driver, shareskillpage);
            //Thread.Sleep(2000);
            //Wait.WaittobeClickable("XPath", 5 , "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input");
            Wait.WaitToBeClickable(driver,"Name", 5 , "title");
            
            shareskillpage.titleTextbox.SendKeys(ExcelLib.ReadData(3, "Column1"));
            //shareskillpage.titleTextbox.SendKeys("Mrs");
            shareskillpage.descriptionTextbox.SendKeys(ExcelLib.ReadData(4, "Column1"));
            //shareskillpage.descriptionTextbox.SendKeys("Software Testing");
            shareskillpage.categoryDropdownbox.Click();
            shareskillpage.selectCategory.Click();
            shareskillpage.subcategoryDropdownbox.Click();
            shareskillpage.selectSubcategory.Click();
            shareskillpage.tagesTextBox.SendKeys(ExcelLib.ReadData(5, "Column1"));
            //shareskillpage.tagesTextBox.SendKeys("Testing");
            shareskillpage.tagesTextBox.SendKeys(Keys.Enter);
            shareskillpage.selectHourlyServiceType.Click();
            shareskillpage.selectLocatiotypeOnSite.Click();
            shareskillpage.startDate.SendKeys(ExcelLib.ReadData(6, "Column1"));
            //shareskillpage.startDate.SendKeys("30/05/2023");
            shareskillpage.endDate.SendKeys(ExcelLib.ReadData(7, "Column1"));
            shareskillpage.endDate.SendKeys("5/06/2023");
            shareskillpage.sunday.Click();
            shareskillpage.sundayStartTime.SendKeys(ExcelLib.ReadData(8, "Column4"));
            shareskillpage.sundayEndTime.SendKeys(ExcelLib.ReadData(8, "Column5"));
            shareskillpage.selecteMonday.Click();
            //shareskillpage.mondayStartTime.SendKeys("08.30am");
            //shareskillpage.mondayEndTime.SendKeys("4.30pm");
            
            shareskillpage.mondayStartTime.SendKeys(ExcelLib.ReadData(8, "Column1"));
            shareskillpage.mondayEndTime.SendKeys(ExcelLib.ReadData(8, "Column2"));

            shareskillpage.tuesday.Click();
            shareskillpage.tuesdayStartTime.SendKeys(ExcelLib.ReadData(9, "Column1"));
            shareskillpage.tuesdayEndTime.SendKeys(ExcelLib.ReadData(9, "Column2"));
            shareskillpage.wednesday.Click();
            shareskillpage.wednesdayStartTime.SendKeys(ExcelLib.ReadData(10, "Column1"));
            shareskillpage.wednesdayEndTime.SendKeys(ExcelLib.ReadData(10, "Column2"));
            shareskillpage.thursday.Click();
            shareskillpage.thursdayStartTime.SendKeys(ExcelLib.ReadData(11, "Column1"));
            shareskillpage.thursdayEndTime.SendKeys(ExcelLib.ReadData(11, "Column2"));
            shareskillpage.friday.Click();
            shareskillpage.fridayStartTime.SendKeys(ExcelLib.ReadData(12,"Column1"));
            shareskillpage.fridayEndTime.SendKeys(ExcelLib.ReadData(12,"Column2"));
            shareskillpage.saturday.Click();
            //shareskillpage.saturdayStartTime.SendKeys(ExcelLib.ReadData(8, "Column7"));
            //shareskillpage.saturEndTime.SendKeys(ExcelLib.ReadData(8, "Coloumn8"));
            shareskillpage.tradeSkillCredit.Click();
            //shareskillpage.skillExchange.SendKeys("Software");
            shareskillpage.creditAmount.SendKeys(ExcelLib.ReadData(13, "Column1"));
            shareskillpage.creditAmount.SendKeys(Keys.Enter);
          
            shareskillpage.workSamples.Click();
            //shareskillpage.titleTextbox.SendKeys(ExcelDataReader.ReadData(3, "Column1"));
            // shareskillpage.descriptionTextbox.SendKeys(ExcelDataReader.ReadData(4,"Column1"));
            //shareskillpage.tagesTextBox.SendKeys(ExcelDataReader.ReadData(5,"Column1"));
            //shareskillpage.startDate.SendKeys(ExcelDataReader.ReadData(6,"Column1"));
            //shareskillpage.endDate.SendKeys(ExcelDataReader.ReadData(7,"Column1"));
            //AutoItX3 AutoIt = new AutoItX3();
            //AutoIt.Initializer(driver, shareskillpage);
            //AutoIt.winActivate("workSamples");
            //AutoIt.Send("C:\\Users\\msswa\\OneDrive\\Desktop\\Industry connect record files\\Work Samples\\Integration_Testing.jpg");
            //AutoIt.Click();
            //Thread.Sleep(6000);
            //Process.Start("C:\\Users\\msswa\\OneDrive\\Desktop\\Work Samples\\FileUploadAutoit.exe");
            //Thread.Sleep(5000);

            Thread.Sleep(3000);
            AutoItX.ControlFocus("Open", "", "Edit1");
            Thread.Sleep(3000);
            AutoItX.ControlSetText("Open", "", "Edit1", "C:\\Users\\msswa\\OneDrive\\Desktop\\Work Samples\\File1.txt");
            Thread.Sleep(2000);
            AutoItX.ControlClick("Open", "", "Button1");
            ExcelLib.ClearData();
            shareskillpage.active.Click();
            Thread.Sleep(3000);
           // Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            shareskillpage.saveButton.Click();
           

            // homepage.manageListingsPage.Click();

            Thread.Sleep(2000);
            string Actualcategory = shareskillpage.category.Text;
            Assert.That(Actualcategory == "Digital Marketing", "Actual category does not match with excepted category");


        }
        [Test, Order(2), Description("checked if user able to Edit Manage Listings record")]
        public void EditManageListings()
        {


            ExtentReporting.LogInfo($"EditManageListings");
           


            var homepage = new HomePage();
            PageFactory.InitElements(driver, homepage);
            Thread.Sleep(3000);
            //Wait.WaitToBeClickable(driver, "XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]");
            homepage.manageListingsPage.Click();

            var managelistingspage = new ManageListingsPage();
            PageFactory.InitElements(driver, managelistingspage);

           // ExcelLib.PopulateInCollection("C:\\Users\\msswa\\OneDrive\\Desktop\\TestData.xlsx", "Sheet2");
            Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]");
            managelistingspage.editMangeListing.Click();
            Wait.WaitToBeClickable(driver, "Name", 5, "title");
            managelistingspage.titleTextbox.Clear();
            //managelistingspage.editTitleTextbox.SendKeys("Ms");
            managelistingspage.titleTextbox.SendKeys(ExcelLib.ReadData(3, "Column2"));
            managelistingspage.editDescriptionTextbox.Clear();
            //managelistingspage.editDescriptionTextbox.SendKeys("Automation Testing");
            managelistingspage.editDescriptionTextbox.SendKeys(ExcelLib.ReadData(4, "Column2"));
            managelistingspage.editCategoryDropdownbox.Click();
            managelistingspage.editCategory.Click();
            managelistingspage.editSubcategoryDropdownbox.Click();
            managelistingspage.editSubcategory.Click();
            managelistingspage.addTagesTextBox.Click();
            //managelistingspage.addTagesTextBox.SendKeys("Automation");
            managelistingspage.addTagesTextBox.SendKeys(ExcelLib.ReadData(5, "Column2"));
            managelistingspage.addTagesTextBox.SendKeys(Keys.Enter);
            managelistingspage.editSelectHourlyServiceType.Click();
            managelistingspage.editSelectLocatiotypeOnline.Click();
            //managelistingspage.editStartDate.SendKeys("01/06/2023");
            managelistingspage.editStartDate.SendKeys(ExcelLib.ReadData(6, "Column2"));
            // managelistingspage.editEndDate.SendKeys("25/06/2023");
            managelistingspage.editEndDate.SendKeys(ExcelLib.ReadData(7, "Column2"));
            managelistingspage.editTradeSkillExchange.Click();
            managelistingspage.skillExchange.Click();
            // managelistingspage.skillExchange.SendKeys("Testing");
            managelistingspage.skillExchange.SendKeys(ExcelLib.ReadData(14, "Column1"));
            managelistingspage.skillExchange.SendKeys(Keys.Enter);
            ExcelLib.ClearData();
            managelistingspage.removeWorkSample.Click();


            //managelistingspage.active.Click();
            Thread.Sleep(3000);
            // Wait.WaitToBeClickable(driver, "Xpath", 5, "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
            managelistingspage.saveButton.Click();

            //Thread.Sleep(2000);
            //homepage.manageListingsPage.Click();

            Thread.Sleep(3000);
            string Actualcategory = managelistingspage.category.Text;
            Assert.That(Actualcategory == "Writing & Translation", " Actualcategory and expected category do not match");

        }
        [Test, Order(3), Description("Check if user can delete the existing manage listing record")]
        public void deleteManageListingRecord()
        {
            ExtentReporting.LogInfo($"DeleteMangeListingRecord");

            

            var homepage = new HomePage();
            PageFactory.InitElements(driver, homepage);

            Thread.Sleep(4000);
            homepage.manageListingsPage.Click();

            var managelistingspage = new ManageListingsPage();
            PageFactory.InitElements(driver, managelistingspage);

            Thread.Sleep(3000);
            managelistingspage.deleteButton.Click();
            managelistingspage.yesButton.Click();

            //Thread.Sleep(3000);
            //homepage.manageListingsPage.Click();


            Thread.Sleep(3000);
            string Actualmessage = managelistingspage.AlertWindow.Text;
            Assert.That(Actualmessage == "Test Analyst has been deleted", " ActualMessage and expected message do not match");
            
        }


    }
}


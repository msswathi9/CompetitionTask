using AutoIt;
using DocumentFormat.OpenXml.Bibliography;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ShareSkill.Pages;
using ShareSkill.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareSkill.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ManageListings : CommonDriver
    {

        [Test, Order(1), Description("checked if user able to Edit Manage Listings record")]

        public void EditManageListings()
        {
            var loginpage = new LoginPage();
            //Console.WriteLine("We are just before PageFactory Init");
            PageFactory.InitElements(driver, loginpage);
            Thread.Sleep(2000);
            loginpage.signInButton.Click();

            ExcelDataReader.PopulateInCollection("C:\\Users\\msswa\\OneDrive\\Desktop\\TestData.xlsx");



            loginpage.userTextBox.SendKeys(ExcelDataReader.ReadData(2, "Column1"));
            loginpage.passwordTestBox.SendKeys(ExcelDataReader.ReadData(2, "Column2"));
            loginpage.loginButton.Click();

            var homepage = new HomePage();
            PageFactory.InitElements(driver, homepage);

            Thread.Sleep(4000);
            homepage.manageListingsPage.Click();

            var managelistingspage = new ManageListingsPage();
            PageFactory.InitElements(driver, managelistingspage);

            Thread.Sleep(2000);
            managelistingspage.editMangeListing.Click();
            managelistingspage.editTitleTextbox.Clear();
            managelistingspage.editTitleTextbox.SendKeys("Ms");
            managelistingspage.editTitleTextbox.SendKeys(ExcelDataReader.ReadData(3, "Column3"));
            managelistingspage.editDescriptionTextbox.Clear();
            managelistingspage.editDescriptionTextbox.SendKeys("Automation Testing");
            managelistingspage.editDescriptionTextbox.SendKeys(ExcelDataReader.ReadData(4, "Column3"));
            managelistingspage.editCategoryDropdownbox.Click();
            managelistingspage.editCategory.Click();
            managelistingspage.editSubcategoryDropdownbox.Click();
            managelistingspage.editSubcategory.Click();
            managelistingspage.addTagesTextBox.Click();
            managelistingspage.addTagesTextBox.SendKeys("Automation");
            managelistingspage.addTagesTextBox.SendKeys(ExcelDataReader.ReadData(5, "Column3"));
            managelistingspage.addTagesTextBox.SendKeys(Keys.Enter);
            managelistingspage.editSelectHourlyServiceType.Click();
            managelistingspage.editSelectLocatiotypeOnline.Click();
            managelistingspage.editStartDate.SendKeys("01/06/2023");
            managelistingspage.editStartDate.SendKeys(ExcelDataReader.ReadData(6, "Column3"));
            managelistingspage.editEndDate.SendKeys("25/06/2023");
            managelistingspage.editEndDate.SendKeys(ExcelDataReader.ReadData(7, "Column3"));
            managelistingspage.editTradeSkillExchange.Click();
            managelistingspage.skillExchange.Click();
            managelistingspage.skillExchange.SendKeys("Testing");
            managelistingspage.skillExchange.SendKeys(Keys.Enter);
            // managelistingspage.removeWorkSample.Click();
            //managelistingspage.workSamples.Click();

            //Thread.Sleep(3000);
            //AutoItX.ControlFocus("Open", "", "Edit1");
            //Thread.Sleep(3000);
            //AutoItX.ControlSetText("Open", "", "Edit1", "C:\\Users\\msswa\\OneDrive\\Desktop\\Work Samples\\CV tips.pdf");
            //Thread.Sleep(2000);
            //AutoItX.ControlClick("Open", "", "Button1");

            //managelistingspage.active.Click();

            Thread.Sleep(3000);
            managelistingspage.saveButton.Click();

            //Thread.Sleep(2000);
            //homepage.manageListingsPage.Click();

            Thread.Sleep(3000);
            string Actualcategory = managelistingspage.category.Text;
            Assert.That(Actualcategory == "Writing & Translation", " Actualcategory and expected category do not match");
            
        }
        [Test, Order (2), Description("Check if user can delete the existing manage listing record")]
        public void deleteManageListingRecord()
        {
            var loginpage = new LoginPage();
            //Console.WriteLine("We are just before PageFactory Init");
            PageFactory.InitElements(driver, loginpage);


            Thread.Sleep(2000);
            loginpage.signInButton.Click();
            loginpage.userTextBox.SendKeys("msswathi9@gmail.com");
            loginpage.passwordTestBox.SendKeys("Abcd@123");
            loginpage.loginButton.Click();

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
            Assert.That(Actualmessage == "Ms has been deleted", " ActualMessage and expected message do not match");
            Thread.Sleep(3000);
            //string Actualcategory = managelistingspage.category.Text;
            //Assert.That(Actualcategory != "Writing & Translation", " Actualcategory and expected category do not match");
        }
        ////[TearDown]
        ////public void PageQuit()
        ////{
        ////    driver.Quit();
        ////}
    }
}

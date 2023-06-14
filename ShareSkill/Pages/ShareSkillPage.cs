using AutoIt;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ShareSkill.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ShareSkill.Pages
{
    public class ShareSkillPage : CommonDriver
    {


        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]

        public IWebElement descriptionTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select")]

        public IWebElement categoryDropdownbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[3]")]

        public IWebElement selectCategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]

        public IWebElement subcategoryDropdownbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")]

        public IWebElement selectSubcategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]

        public IWebElement tagesTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]

        public IWebElement selectHourlyServiceType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]

        public IWebElement selectLocatiotypeOnSite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]

        public IWebElement startDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]

        public IWebElement endDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]

        public IWebElement sunday { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        public IWebElement sundayStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")]
        public IWebElement sundayEndTime { get; set; }



        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[1]/div[1]/input[1]")]
        public IWebElement selecteMonday { get; set; }

       

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]

        public IWebElement mondayStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]

        public IWebElement mondayEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")]

        public IWebElement tuesday { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]

        public IWebElement tuesdayStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]

        public IWebElement tuesdayEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")]

        public IWebElement wednesday { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]

        public IWebElement wednesdayStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name=\"EndTime\" and @index=\"3\"]")]

        public IWebElement wednesdayEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")]

        public IWebElement thursday { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
        public IWebElement thursdayStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
        public IWebElement thursdayEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input")]

        public IWebElement friday { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input")]
        public IWebElement fridayStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input")]
        public IWebElement fridayEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[1]/div/input")]

        public IWebElement saturday { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")]
        public IWebElement saturdayStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input")]
        public IWebElement saturEndTime { get; set; }






        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]

        public IWebElement tradeSkillCredit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input")]

        public IWebElement creditAmount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]

        public IWebElement skillExchange { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]

        public IWebElement workSamples { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]

        public IWebElement active { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]")]

        public IWebElement saveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")]

        public IWebElement category;


    }
}

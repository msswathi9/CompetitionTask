using DocumentFormat.OpenXml.Bibliography;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ShareSkill.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareSkill.Pages
{
    public class ManageListingsPage : CommonDriver
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]")]
        public IWebElement editMangeListing { get; set; }


        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]

        public IWebElement editDescriptionTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select")]

        public IWebElement editCategoryDropdownbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[4]")]

        public IWebElement editCategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]

        public IWebElement editSubcategoryDropdownbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]")]

        public IWebElement editSubcategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]

        public IWebElement addTagesTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]

        public IWebElement editSelectHourlyServiceType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]

        public IWebElement editSelectLocatiotypeOnline { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]

        public IWebElement editStartDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]

        public IWebElement editEndDate { get; set; }

        [FindsBy(How = How.XPath)]

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]

        public IWebElement editTradeSkillExchange { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div[1]/div/div/div/div/input")]

        public IWebElement skillExchange { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/div/i[1]")]
        public IWebElement removeWorkSample { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]

        public IWebElement workSamples { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]

        public IWebElement active { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]")]

        public IWebElement saveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")]

        public IWebElement category;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")]

        public IWebElement deleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]

        public IWebElement yesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]

        public IWebElement AlertWindow;

    }
}


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

        //[FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a")]

        //private IWebElement shareSkillPage { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]

        public IWebElement titleTextbox { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]

        public IWebElement descriptionTextbox { get;set; }

        [FindsBy(How =How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select")]

        public IWebElement categoryDropdownbox { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[3]")]

        public IWebElement selectCategory { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]

        public IWebElement subcategoryDropdownbox { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")]
        
        public IWebElement selectSubcategory { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]

        public IWebElement tagesTextBox { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]

        public IWebElement selectHourlyServiceType { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]

        public IWebElement selectLocatiotypeOnSite { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
         
        public IWebElement startDate { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]

        public IWebElement endDate { get; set; }

        [FindsBy(How=How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[1]/div[1]/input[1]")]
        public IWebElement selecteMonday { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]

        public IWebElement mondayEndTime { get; set; }



        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]

        public IWebElement mondayStartTime { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]

        public IWebElement tradeSkillCredit { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]

        public IWebElement skillExchange { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]

        public IWebElement workSamples { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]

        public IWebElement active { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]")]

        public IWebElement saveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")]

        public IWebElement category;

       
       


     }
}

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ShareSkill.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShareSkill.Pages
{
    public class HomePage: CommonDriver
    {
        [FindsBy(How=How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a")]

        public IWebElement shareSkillPage { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]")]

        public IWebElement manageListingsPage { get; set; }
        

        //Share skill page
        //private IWebElement shareSkillPage => CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));

        //Manage listing Page
        //private IWebElement manageListingPage => CommonDriver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]"));

       
        public void ShareSkillPage()
        {
           // Thread.Sleep(3000);
            Wait.WaitToBeClickable(driver,"XPath",5, "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a");
            shareSkillPage.Click();
        }
        public void ManageListingsPage()
        {
           // Thread.Sleep(3000);
            Wait.WaitToBeClickable(driver, "XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]");
            manageListingsPage.Click();
        }

       
    }
}

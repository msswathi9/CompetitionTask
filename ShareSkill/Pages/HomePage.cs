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
    public class HomePage
    {
        [FindsBy(How=How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a")]

        public IWebElement shareSkillPage { get; set; }

        [FindsBy(How=How.CssSelector, Using = "div:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu > a.item:nth-child(3)")]

        public IWebElement manageListingsPage { get; set; }
        

        //Share skill page
        //private IWebElement shareSkillPage => CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));

        //Manage listing Page
        //private IWebElement manageListingPage => CommonDriver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]"));

       
        

    }
}

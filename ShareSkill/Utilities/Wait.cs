using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareSkill.Utilities
{
    public class Wait
    {
        public void WaittobeClickable(IWebDriver driver, string locatertype, string locatervalue, int seconds)
        {
            var Wait = new WebDriverWait(driver, new TimeSpan(0, 0,seconds));
            if (locatertype == "Xpath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatertype)));
            }
            if(locatertype == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatertype)));
            }
            if(locatertype == "Csselector")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatertype)));
            }
        }
    }
}

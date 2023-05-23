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
   


    public class LoginPage
    {
        [FindsBy(How=How.XPath, Using = "//*[@id=\"home\"]/div/div/div[1]/div/a")]
       [CacheLookup]
        public IWebElement signInButton  { get; set; }

        [FindsBy(How=How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement userTextBox { get; set; }

        [FindsBy(How=How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement passwordTestBox { get; set; }

        [FindsBy(How=How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]

        public IWebElement loginButton { get; set; }

        //private IWebElement signInButton => CommonDriver.driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        //private IWebElement userTextBox => CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        //private IWebElement passwordTextBox => CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        //private IWebElement loginButton => CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));


        public void loginActions(IWebDriver driver)
        {

            //Open chrome Browser
            // driver = new ChromeDriver();

           driver.Manage().Window.Maximize();

            //Launch Mars URL

          driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //Thread.Sleep(2000);
            //Wait.WaittobeClickable(driver, "Xpath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);
            //signInButton.Click();

            //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
            //userTextBox.SendKeys("msswathi9@gmail.com");

            //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[2]/input", 5);
            //passwordTextBox.SendKeys("Abcd@123");

            //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 5);
            //Thread.Sleep(2000);
            //loginButton.Click();


        }
        //public void SigninButton()
        //{
        //    // Thread.Sleep(2000);
        //    // Wait.WaittobeClickable(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);

        //    signInButton.Click();
        //}
        //public void UserTextBox()
        //{
        //    //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
        //    userTextBox.SendKeys("msswathi9@gmail.com");
        //}
        //public void PasswordTextBox()
        //{
        //    // Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[2]/input", 5);
        //    passwordTestBox.SendKeys("Abcd@123");
        //}
        //public void LogInButton()
        //{
        //    //Wait.WaittobeClickable(driver, "Xpath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 5);
        //    Thread.Sleep(2000);

        //    loginButton.Click();
        //}
    }
}

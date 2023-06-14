﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareSkill.Utilities.Reports
{
    public class Browser
    {
        private IWebDriver driver;
        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetScreenShot()
        {
            Thread.Sleep(200);
            var file = ((ITakesScreenshot)driver).GetScreenshot();
            var img = file.AsBase64EncodedString;

            return img;
        }
    }
}

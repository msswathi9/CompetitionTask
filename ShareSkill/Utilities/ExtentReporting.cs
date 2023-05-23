using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;

using AventStack.ExtentReports.Reporter;

namespace ShareSkill.Utilities
{

    public class ExtentReports
    {
        private static ExtentReports extentReport;
        private static ExtentTest extentTest;

       
        private static ExtentReports StartReporting()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\Result\";

            if (ExtentReports == null)
            {
                Directory.CreateDirectory(path);

                ExtentReports = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter(path);

                ExtentReports.AttachReporter(htmlReporter);
            }
            return ExtentReports;
        }

        public static void CreateTest(string testName)
        {
            extentTest = StartReporting().CreateTest(testName);
        }

        public static void EndReporting()
        {
            StartReporting().Flush();
        }

        public static void LogPass(string info)
        {
            extentTest.Pass(info);
        }

        public static void LogFail(string info)
        {
            extentTest.Fail(info);
        }

        public static void LogInfo(string info)
        {
            extentTest.Info(info);
        }

        public static void LogScreenShot(string info, string image)
        {
            extentTest.Info(info, MediaEntityBuilder.CreateScreenCaptureFromBase64String(image).Build());
        }
    }
}

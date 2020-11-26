using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TechFabricSln.Test
{
    public class SeleniumTest
    {


        [Test]
        [Category("UITests")]
        public void VisitMicrosoft_CheckWindowsMenu()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.microsoft.com/");
            Thread.Sleep(10000);
            string Windows_text = driver.FindElement(By.Id("shellmenu_2")).Text;
            Assert.AreEqual("Windows", Windows_text);
            driver.Quit();
        }

    }

}

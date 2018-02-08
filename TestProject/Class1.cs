using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NUnit.Framework.Interfaces;



namespace TestProject
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void OpenGoogle()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.Quit();
           
        }
    }
}

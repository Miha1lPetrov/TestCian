using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CianTest
{
    internal class TestBase
    {
        protected WebDriver driver;  

        [SetUp]
        public void SetUp()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://ya.ru/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}

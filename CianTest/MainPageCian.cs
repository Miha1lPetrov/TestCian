using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace CianTest
{
    internal class MainPageCian
    {
        private WebDriver driver;
        public MainPageCian(WebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By takeOffBtn = By.XPath("//a[text()='Снять']");
        private readonly By searchPage = By.XPath("//input[@id='geo-suggest-input']");
        private readonly By searchBtn = By.XPath("//a[text()='Найти']");

        public void TakeOffBtnClick()
        {
            driver.FindElement(takeOffBtn).Click();
        }
        public void SearchPageItem(string item)
        {
            driver.FindElement(searchPage).Click();
            driver.FindElement(searchPage).SendKeys(item);
            driver.FindElement(searchPage).SendKeys(Keys.Enter);

        }
        public void SearchBtnClick() 
        {
            driver.FindElement(searchBtn).Click();
            Thread.Sleep(1000);
        }
    }
}

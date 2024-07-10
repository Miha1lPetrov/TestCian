using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CianTest
{
    internal class MainPageYa
    {
        private WebDriver driver;

        public MainPageYa(WebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By searchPage = By.XPath("//input[@aria-label='Запрос']");
        private readonly By popWindowBtn = By.XPath("//button[@title='Нет, спасибо']");
        private readonly By clickCian = By.XPath("//b[text()='izhevsk.cian.ru']");
        public void SearchItem(string item)
        {
            driver.FindElement(searchPage).Click();
            driver.FindElement(searchPage).SendKeys(item);
            driver.FindElement(searchPage).SendKeys(Keys.Enter);
        }
        public void PopUpWindow()
        {
            Thread.Sleep(1000);
            driver.FindElement(popWindowBtn).Click();
        }
        public void SwitchingToCian()
        {
            driver.FindElement(clickCian).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(1000);
        }


    }
}

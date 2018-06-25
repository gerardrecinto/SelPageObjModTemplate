using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;

namespace TritonLinkTests.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='tdr_content_content']/div[1]/div/div/button")]
        private IWebElement menuElement;

        [FindsBy(How = How.XPath, Using = "//*[@id='tdr_content_content']/div[1]/div/div/div/ul/li[2]/a")]
        private IWebElement myTritonLinkElement;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://students.ucsd.edu/");

        }

        public void login()
        {
            //selfWait(menuElement);
            //menuElement.Click();
            selfWait(myTritonLinkElement);
            myTritonLinkElement.Click();
        }

        public void selfWait(IWebElement element){
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

    }
}

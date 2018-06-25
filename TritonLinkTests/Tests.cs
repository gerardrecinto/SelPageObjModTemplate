using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TritonLinkTests.PageObjects;
namespace TritonLinkTests
{
    public class Tests
    {
        private IWebDriver driver;


        [SetUp]
        public void BeforeEachTest()
        {
            driver = new ChromeDriver(@"/Users/gerardrecinto/Desktop");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Login()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            home.login();
        }

        [TearDown]
        public void TearDown(){
            driver.Close();
        }
        static void Main(string[] args)
        {
            Tests t = new Tests();
            t.BeforeEachTest();
            t.Login();
            t.TearDown();
        }
    }
}

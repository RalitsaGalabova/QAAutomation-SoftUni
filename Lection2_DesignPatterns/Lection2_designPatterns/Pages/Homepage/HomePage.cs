using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.Homepage
{
    public class HomePage
    {
        private String url = "http://www.demoqa.com";
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.ClassName, Using = "entry-title")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-374']")]
        public IWebElement RegistrationButton { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }
    }
}

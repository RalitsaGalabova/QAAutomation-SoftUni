using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.SelectablePage
{
    public partial class SelectablePage
    {
        public IWebElement FirstItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='selectable']/li[1]"));
            }
        }

        public IWebElement SecondItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='selectable']/li[1]"));
            }
        }
        public IWebElement FiveItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='selectable']/li[5]"));
            }
        }
        public IWebElement Serializeutton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }
        public IWebElement Title
        {
            get
            {
                return this.Driver.FindElement(By.Id("feedback"));
            }
        }
        public IWebElement FirstItemSeriliaze
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='selectable-serialize']/li[1]"));
            }
        }
    }
}

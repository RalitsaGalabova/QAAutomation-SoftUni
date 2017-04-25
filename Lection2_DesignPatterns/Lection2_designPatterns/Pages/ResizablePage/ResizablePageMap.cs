using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public IWebElement ResizeElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable"));
            }
        }

        public IWebElement ResizeButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='resizable']/div[3]"));
            }
        }

        public IWebElement AnimateButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }

        public IWebElement AnimateResizeButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='resizableani']/div[3]"));
            }
        }
        public IWebElement AnimateElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizableani"));
            }
        }
    }
}

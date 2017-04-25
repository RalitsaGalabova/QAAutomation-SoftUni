using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.AutomationPracticePage
{
    public partial class AutomationPage
    {
        public IWebElement NewBrowserTabButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='content']/p[4]/button"));
            }
        }
    }
}

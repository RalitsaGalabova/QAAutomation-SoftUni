using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Lection2_designPatterns.Pages.ToolsQAHomePage
{
    public partial class ToolsQAHomePage
    {
        public IWebElement logo
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='page']/div[1]/header/div/a/img"));
            }
        }

    }
}

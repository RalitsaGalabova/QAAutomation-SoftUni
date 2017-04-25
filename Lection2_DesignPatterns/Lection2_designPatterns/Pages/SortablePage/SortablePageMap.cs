using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.SortablePage
{
    public partial class SortablePage
    {
        public IWebElement FirstItem
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[1]"));
            }
        }

        public IWebElement ThirdItem
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[3]"));
            }
        }

        public IWebElement SeventhItem
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[7]"));
            }
        }
    }
}

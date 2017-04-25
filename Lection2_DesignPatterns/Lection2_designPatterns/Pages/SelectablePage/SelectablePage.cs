using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Lection2_designPatterns.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        {
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/selectable/");
        }
    }
}

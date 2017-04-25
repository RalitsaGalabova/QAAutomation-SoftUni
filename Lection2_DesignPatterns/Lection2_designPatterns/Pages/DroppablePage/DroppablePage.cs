using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Lection2_designPatterns.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver) : base(driver)
        {

        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/droppable/");
        }
    }
}

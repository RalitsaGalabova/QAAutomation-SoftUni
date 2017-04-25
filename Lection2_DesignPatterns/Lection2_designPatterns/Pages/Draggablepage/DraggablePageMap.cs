using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.Draggablepage
{
    public partial class DraggablePage
    {
        public IWebElement DefaultDragElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggable"));
            }
        }

        public IWebElement EventsButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-4"));
            }
        }

        public IWebElement DragEventElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("dragevent"));
            }
        }

        public IWebElement EventStartButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("event-start"));
            }
        }

        public IWebElement StartEventCount
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='event-start']/span[2]"));
            }
        }

        public IWebElement DragEventCount
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='event-drag']/span[2]"));
            }
        }

        public IWebElement DraggableAndSortableButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-5"));
            }
        }

        public IWebElement FirstListItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='sortablebox']/li[1]"));
            }
        }

        public IWebElement SecondListItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='sortablebox']/li[2]"));
            }
        }

        public IWebElement LastListItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='sortablebox']/li[5]"));
            }
        }
    }
}

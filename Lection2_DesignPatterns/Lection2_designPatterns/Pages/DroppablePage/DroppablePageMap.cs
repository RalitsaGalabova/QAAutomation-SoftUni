using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public IWebElement DragElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableview"));
            }
        }

        public IWebElement DropElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableview"));
            }
        }

        public IWebElement AcceptButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));

            }
        }
        public IWebElement NotDroppableElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggable-nonvalid"));

            }
        }

        public IWebElement AcceptDraggableElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableaccept"));

            }
        }

        public IWebElement AcceptTargetElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableaccept"));

            }
        }

        public IWebElement AcceptParagraph
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='droppableaccept']/p"));

            }
        }

    }
}
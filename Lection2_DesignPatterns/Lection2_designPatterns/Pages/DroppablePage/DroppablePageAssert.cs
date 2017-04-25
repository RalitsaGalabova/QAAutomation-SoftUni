using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.DroppablePage
{
    public static class DroppablePageAssert
    {
        public static void ElementIsDropped(this DroppablePage page)
        {
            Assert.AreEqual("ui-widget-header ui-droppable ui-state-highlight", page.DropElement.GetAttribute("class"));
        }

        public static void AcceptElementIsDropped(this DroppablePage page)
        {

            Assert.AreEqual("Dropped!", page.AcceptParagraph.Text);
        }

        public static void AcceptElementIsNotDropped(this DroppablePage page)
        {

            Assert.AreEqual("accept: ‘#draggableaccept’", page.AcceptParagraph.Text);
        }
    }


}

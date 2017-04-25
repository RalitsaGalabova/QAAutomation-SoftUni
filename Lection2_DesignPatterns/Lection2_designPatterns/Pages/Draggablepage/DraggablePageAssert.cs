using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.Draggablepage
{
    public static class DraggablePageAssert
    {
        public static void DefaultElementIsDragged(this DraggablePage page)
        {
            Assert.AreEqual("position: relative; width: 246px; right: auto; height: 150px; bottom: auto; left: 200px; top: 200px;",
                            page.DefaultDragElement.GetAttribute("style"));
        }

        public static void AssertStartEvent(this DraggablePage page)
        {
            Assert.AreEqual("1",page.StartEventCount.Text);
        }

        public static void AssertDragEventCount(this DraggablePage page)
        {
            Assert.AreEqual("1", page.DragEventCount.Text);
        }

        public static void AssertListItemIsMoved(this DraggablePage page)
        {
            
            Assert.AreEqual("Item 1", page.LastListItem.Text);
        }
    }
}

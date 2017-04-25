using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.SortablePage
{
    public static class SortablePageAssert
    {
        public static void AssertFirstSelection(this SortablePage page)
        {
            Assert.AreEqual("Item 1", page.ThirdItem.Text);
        }

        public static void AssertSecondSelection(this SortablePage page)
        {
            Assert.AreEqual("Item 3", page.FirstItem.Text);
        }

        public static void AssertThirdSelection(this SortablePage page)
        {
            Assert.AreEqual("Item 1", page.SeventhItem.Text);
        }

    }
}

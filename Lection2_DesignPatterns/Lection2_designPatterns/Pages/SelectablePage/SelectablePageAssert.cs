using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.SelectablePage
{
    public static class SelectablePageAssert
    {
        public static void FirstItemIsSelected(this SelectablePage page)
        {
            Assert.AreEqual("ui-widget-content ui-corner-left ui-selectee ui-selected", page.FirstItem.GetAttribute("class"));
        }

        public static void SelectMoreThanOneItem(this SelectablePage page)
        {
            Assert.AreEqual("ui-widget-content ui-corner-left ui-selectee ui-selected", page.FirstItem.GetAttribute("class"));
            Assert.AreEqual("ui-widget-content ui-corner-left ui-selectee ui-selected", page.SecondItem.GetAttribute("class"));
            Assert.AreEqual("ui-widget-content ui-corner-left ui-selectee ui-selected", page.FiveItem.GetAttribute("class"));
        }

        public static void AssertTitle(this SelectablePage page)
        {
            Assert.AreEqual("You’ve selected: #1#2#3#4#5#6.", page.Title.Text);
        }
    }
}

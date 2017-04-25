using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.ResizablePage
{
    public static class ResizablePageAssert
    {
        public static void ElementIsResized(this ResizablePage page)
        {
            var width = page.ResizeElement.Size.Width;
            var height = page.ResizeElement.Size.Height;
            Assert.IsTrue(width > 200);
            Assert.IsTrue(height > 200);
        }
        public static void AssertAnimateResizeElement(this ResizablePage page)
        {
            var width = page.AnimateElement.Size.Width;
            var height = page.AnimateElement.Size.Height;
            Assert.IsTrue(width > 100);
            Assert.IsTrue(height > 100);
        }
    }
}

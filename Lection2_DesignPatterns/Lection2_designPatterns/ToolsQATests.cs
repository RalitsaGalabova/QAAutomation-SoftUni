using Lection2_designPatterns.Pages.AutomationPracticePage;
using Lection2_designPatterns.Pages.Draggablepage;
using Lection2_designPatterns.Pages.DroppablePage;
using Lection2_designPatterns.Pages.ResizablePage;
using Lection2_designPatterns.Pages.SelectablePage;
using Lection2_designPatterns.Pages.SortablePage;
using Lection2_designPatterns.Pages.ToolsQAHomePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lection2_designPatterns
{
    [TestFixture]
    public class ToolsQATests
    {
        private IWebDriver driver;
        private Actions builder;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.builder = new Actions(this.driver);

        }

        [TearDown]
        public void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        " + TestContext.CurrentContext.WorkDirectory + "            " + TestContext.CurrentContext.Result.PassCount);

                var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
                driver.Quit();
            }
            driver.Quit();
        }

        //Draggable - 5 tests

        [Test]
        public void DragDefaultElement()
        {
            var draggablePage = new DraggablePage(this.driver);
            draggablePage.NavigateTo();
            builder.DragAndDropToOffset(draggablePage.DefaultDragElement, 200, 200).Perform();
            draggablePage.DefaultElementIsDragged();

        }

        [Test]
        public void DragElementUsingClickAndHold()
        {
            var draggablePage = new DraggablePage(this.driver);
            draggablePage.NavigateTo();
            builder.MoveToElement(draggablePage.DefaultDragElement).ClickAndHold().MoveByOffset(200, 200).Release().Perform();
            draggablePage.DefaultElementIsDragged();

        }

        [Test]
        public void CheckStartEventCount()
        {
            var draggablePage = new DraggablePage(this.driver);
            draggablePage.NavigateTo();
            draggablePage.EventsButton.Click();
            builder.DragAndDropToOffset(draggablePage.DragEventElement, 200, 200).Perform();
            draggablePage.AssertDragEventCount();
        }

        [Test]
        public void CheckDragEventCount()
        {
            var draggablePage = new DraggablePage(this.driver);
            draggablePage.NavigateTo();
            draggablePage.EventsButton.Click();
            builder.DragAndDropToOffset(draggablePage.DragEventElement, 50, -50).Perform();
            draggablePage.AssertDragEventCount();


        }

        [Test]
        public void DragElemenFromList()
        {
            var draggablePage = new DraggablePage(this.driver);
            draggablePage.NavigateTo();
            draggablePage.DraggableAndSortableButton.Click();
            builder.MoveToElement(draggablePage.FirstListItem).ClickAndHold().MoveByOffset(10, 100).Release().Perform();
            Thread.Sleep(500);
            draggablePage.AssertListItemIsMoved();


        }
        //Droppable - 5 tests
        [Test]
        public void FirstTastCase()
        {
            var droppablePage = new DroppablePage(this.driver);
            droppablePage.NavigateTo();
            Actions builder = new Actions(this.driver);
            builder.DragAndDrop(droppablePage.DragElement, droppablePage.DropElement).Perform();
            droppablePage.ElementIsDropped();
        }

        [Test]
        public void SecondTastCase()
        {
            var droppablePage = new DroppablePage(this.driver);
            droppablePage.NavigateTo();
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(droppablePage.DragElement).ClickAndHold().MoveToElement(droppablePage.DropElement).Release().Perform();
            droppablePage.ElementIsDropped();
        }

        [Test]
        public void AcceptElementIsDropped()
        {
            var droppablePage = new DroppablePage(this.driver);
            droppablePage.NavigateTo();
            droppablePage.AcceptButton.Click();
            Actions builder = new Actions(this.driver);
            builder.DragAndDrop(droppablePage.AcceptDraggableElement, droppablePage.AcceptTargetElement).Perform();
            droppablePage.AcceptElementIsDropped();
        }

        [Test]
        public void AcceptElementIsNotDropped()
        {
            var droppablePage = new DroppablePage(this.driver);
            droppablePage.NavigateTo();
            droppablePage.AcceptButton.Click();
            Actions builder = new Actions(this.driver);
            builder.DragAndDrop(droppablePage.NotDroppableElement, droppablePage.AcceptTargetElement).Perform();
            droppablePage.AcceptElementIsNotDropped();
        }
        [Test]
        public void ElementIsDroppedWithMoveTo()
        {
            var droppablePage = new DroppablePage(this.driver);
            droppablePage.NavigateTo();
            droppablePage.AcceptButton.Click();
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(droppablePage.AcceptDraggableElement).ClickAndHold().MoveToElement(droppablePage.AcceptTargetElement).Release().Perform();
            droppablePage.AcceptElementIsDropped();

        }

        //Resizable - 3 tests
        [Test]
        public void ResizeElement()
        {
            var resizablepage = new ResizablePage(this.driver);
            resizablepage.NavigateTo();
            Actions builder = new Actions(this.driver);
            var firstAction = builder.DragAndDropToOffset(resizablepage.ResizeButton, 200, 200).Build();
            firstAction.Perform();
            resizablepage.ElementIsResized();


        }

        [Test]
        public void AnimateResizeElement()
        {
            var resizablepage = new ResizablePage(this.driver);
            resizablepage.NavigateTo();
            IWebElement button = resizablepage.AnimateButton;
            button.Click();
            Actions builder = new Actions(this.driver);
            var firstAction = builder.DragAndDropToOffset(resizablepage.AnimateResizeButton, 50, 50).Build();
            firstAction.Perform();
            resizablepage.AssertAnimateResizeElement();
        }

        [Test]
        public void ResizeElementWithMoveTo()
        {
            var resizablepage = new ResizablePage(this.driver);
            resizablepage.NavigateTo();
            Actions builder = new Actions(this.driver);
            var firstAction = builder.MoveToElement(resizablepage.ResizeButton).ClickAndHold().MoveByOffset(200, 200).Release();
            firstAction.Perform();
            resizablepage.ElementIsResized();


        }
        //Selectable - 3 tests

        [Test]
        public void SelectOneElement()
        {
            var selectablePage = new SelectablePage(this.driver);
            selectablePage.NavigateTo();
            Actions builder = new Actions(this.driver);
            var firstAction = builder.MoveToElement(selectablePage.FirstItem).Click();
            firstAction.Perform();
            selectablePage.FirstItemIsSelected();


        }

        [Test]
        public void MultipleSelect()
        {
            var selectablePage = new SelectablePage(this.driver);
            selectablePage.NavigateTo();
            Actions builder = new Actions(this.driver);
            builder.KeyDown(Keys.Control);
            builder.MoveToElement(selectablePage.FirstItem).Click().Perform();
            builder.MoveToElement(selectablePage.SecondItem).Click().Perform();
            builder.MoveToElement(selectablePage.FiveItem).Click().Perform();
            builder.KeyUp(Keys.Control);
            selectablePage.SelectMoreThanOneItem();


        }

        [Test]
        public void SelectWithMoveTo()
        {
            var selectablePage = new SelectablePage(this.driver);
            selectablePage.NavigateTo();
            selectablePage.Serializeutton.Click();
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(selectablePage.FirstItemSeriliaze).ClickAndHold().MoveByOffset(0, 200).Release().Perform();
            selectablePage.AssertTitle();


        }

        //Sortable - 3 tests
        [Test]
        public void TestFirstSelection()
        {
            var sortablePage = new SortablePage(this.driver);
            sortablePage.NavigateTo();
            Actions builder = new Actions(this.driver);
            //var action = builder.DragAndDrop(sortablePage.FirstItem, sortablePage.SecondItem);
            builder.MoveToElement(sortablePage.FirstItem).ClickAndHold().MoveByOffset(0, 70).Release().Perform();
            //action.Perform();
            sortablePage.AssertFirstSelection();            


        }

        [Test]
        public void TestSecondSelection()
        {
            var sortablePage = new SortablePage(this.driver);
            sortablePage.NavigateTo();
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(sortablePage.ThirdItem).ClickAndHold().MoveByOffset(0, -70).Release().Perform();
            sortablePage.AssertSecondSelection();


        }

        [Test]
        public void TestLastSelection()
        {
            var sortablePage = new SortablePage(this.driver);
            sortablePage.NavigateTo();
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(sortablePage.FirstItem).ClickAndHold().MoveByOffset(0, 200).Release().Perform();
            sortablePage.AssertThirdSelection();


        }


    }
}

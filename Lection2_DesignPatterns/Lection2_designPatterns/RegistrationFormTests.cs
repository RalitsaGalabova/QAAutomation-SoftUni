using Lection2_designPatterns.Modules;
using Lection2_designPatterns.Pages.Homepage;
using Lection2_designPatterns.Pages.RegistrationPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns
{
    [TestFixture]
    public class RegistrationFormTests
    {
        private IWebDriver driver;
        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void Close()
        {
            this.driver.Quit();
        }

        [Test]
        public void NaavigateToRegistrationPage()
        {
            HomePage homePage = new HomePage(this.driver);
            PageFactory.InitElements(driver, homePage);
            homePage.Navigate();
            Assert.AreEqual("Home", homePage.Header.Text);
        }


        [Test]
        public void RegistrationWithoutName()
        {
            var regPage = new RegistrationPage(driver);
            var user = AccessExcelData.GetTestData("RegistrationWithoutName");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertNamesErrorMessage("* This field is required");
        }

        [Test]
        public void RegistrationWithoutLastName()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithoutLastName");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertNamesErrorMessage("* This field is required");

        }

        [Test]
        public void RegistrationWithoutPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithoutPhone");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertPhoneErrorMessage("* This field is required");


        }

        [Test]
        public void RegistrationWithoutHobby()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithoutHobby");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertEmptyHobby("* This field is required");

         }

        [Test]
        public void RegistrationWithInvalidPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithInvalidPhone");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AsserInvalidPhone("* Minimum 10 Digits starting with Country Code");

        }

        [Test]
        public void RegistrationWithEmptyUserName()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithEmptyUserName");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertEmptyUserName("* This field is required");

        }

        [Test]
        public void RegistrationWithAlreadyExistUserName()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithAlreadyExistUserName");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertExistUser("Error: Username already exists");
        }

        [Test]
        public void RegistrationWithoutEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithoutEmail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertEmptyMail("* This field is required");
        }

        [Test]
        public void RegistrationWithInvalidEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithInvalidEmail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertInvalidEmail("* Invalid email address");
        }

        [Test]
        public void RegistrationWithoutPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithoutPassword");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertEmptyPassword("* This field is required");
        }

        [Test]
        public void RegistrationWithoutConfirmPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithoutConfirmPassword");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertEmptyConfirmPassword("* This field is required");
        }

        [Test]
        public void RegistrationWithShortPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("RegistrationWithShortPassword");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertShortPassword("* Minimum 8 characters required");
        }

        [Test]
        public void PasswordDoNotMatch()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("PasswordDoNotMatch");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertPasswordDoNotMatch("* Fields do not match");
        }

        [Test]
        public void PasswordMatch()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("PasswordMatch");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertPasswordMatch();
        }

        [Test]
        public void EmailExist()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("EmailExist");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertEmailExist("Error: E-mail address already exists");
        }

        [Test]
        public void DescriptionFieldIsFilledIn()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("DescriptionFieldIsFilledIn");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertYouCanWriteInAboutYourselfField("Hello!");
        }

        [Test]
        public void HobbyIsSelected()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("HobbyIsSelected");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.HobbyisSelected();
        }

        [Test]
        public void SelectTwoHobbies()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("SelectTwoHobbies");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertSelectTwoHobbies();
        }

        [Test]
        public void MaritalStatusIsSelected()
        {
            var regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("MaritalStatusIsSelected");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertMaritalStatusIsSelected();
        }  
        
    }
}

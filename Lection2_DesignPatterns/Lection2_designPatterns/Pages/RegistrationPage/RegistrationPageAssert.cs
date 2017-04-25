using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.RegistrationPage
{
    public static class RegistrationPageAssert
    {

        public static void AssertRegistrationPageIsOpen(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }

        public static void AssertNamesErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNames.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNames.Text);
        }

        public static void AssertPhoneErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPhone.Text);
        }

        public static void AssertEmptyLastName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForLastName.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForLastName.Text);
        }

        public static void AssertEmptyHobby(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForHobby.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForHobby.Text);
        }

        public static void AsserInvalidPhone(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalidPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForInvalidPhone.Text);
        }

        public static void AssertEmptyUserName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmptyUserName.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForEmptyUserName.Text);
        }

        public static void AssertExistUser(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForAlreadyExistUserName.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForAlreadyExistUserName.Text);
        }

        public static void AssertEmptyMail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmptyEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForEmptyEmail.Text);
        }

        public static void AssertInvalidEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalidEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForInvalidEmail.Text);
        }

        public static void AssertEmptyPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmptyPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForEmptyPassword.Text);
        }

        public static void AssertEmptyConfirmPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmptyConfirmPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForEmptyConfirmPassword.Text);
        }

        public static void AssertShortPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForShortPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForShortPassword.Text);
        }

        public static void AssertPasswordDoNotMatch(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPasswordDoNotMatch.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForPasswordDoNotMatch.Text);
        }

        public static void AssertPasswordMatch(this RegistrationPage page)
        {
            Assert.AreEqual(page.ConfirmPassword.Text, page.Password.Text);
        }

        public static void AssertEmailExist(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageEmailAlreadyExist.Displayed);
            StringAssert.Contains(text, page.ErrorMessageEmailAlreadyExist.Text);
        }

        public static void AssertYouCanWriteInAboutYourselfField(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.Description.Text);
        }

        public static void HobbyisSelected(this RegistrationPage page)
        {
            String box = page.DanceHobbyCheckBox.GetAttribute("checked");
            Assert.AreEqual("true", box);
        }

        public static void AssertSelectTwoHobbies(this RegistrationPage page)
        {
            String firstHobby = page.DanceHobbyCheckBox.GetAttribute("checked");
            String secondHobby = page.ReadingHobbyCheckBox.GetAttribute("checked");
            Assert.AreEqual("true", firstHobby);
            Assert.AreEqual("true", secondHobby);


        }
        public static void AssertMaritalStatusIsSelected(this RegistrationPage page)
        {
            var status = page.MarriedStatus.Selected;
            Assert.AreEqual(true, status);
        }
    }
}



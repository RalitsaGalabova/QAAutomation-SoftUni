using Lection2_designPatterns.Modules;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
        }

        public void FillRegistrationForm(RegistrationUser user)
        {
            Type(FirstName, user.FirstName);
            Type(LastName, user.LastName);
            ClickOnElements(MaritalStatus, user.MaritalStatus);
            ClickOnElements(Hobby, user.Hobby);
            CountryOption.SelectByText(user.Country);
            MounthOption.SelectByText(user.BirthMonth);
            DayOption.SelectByText(user.BirthDay);
            YearOption.SelectByText(user.BirthYear);
            Type(Phone, user.Phone);
            Type(UserName, user.UserName);
            Type(Email, user.Email);
            Type(Description, user.Description);
            Type(Password, user.Password);
            Type(ConfirmPassword, user.ConfirmPassword);
            SubmitButton.Click();
        }

        private void ClickOnElements(List<IWebElement> elements, string conditions)
        {
            var selected = conditions.Split();
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i].Equals("true"))
                {
                    elements[i].Click();
                }
            }
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.Click();

            if (!text.Equals("null")) { element.SendKeys(text); }
            
        }

    }

    
}

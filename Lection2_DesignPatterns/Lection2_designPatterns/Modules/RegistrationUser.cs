using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2_designPatterns.Modules
{
    public class RegistrationUser
    {

        private string key;
        private string firstName;
        private string lastName;
        private string maritalStatus;
        private string hobby;
        private string country;
        private string birthMonth;
        private string birthDay;
        private string birthYear;
        private string phone;
        private string userName;
        private string email;
        //private string picture;
        private string description;
        private string password;
        private string confirmPassword;

        public RegistrationUser(string key,
                                string firstName, 
                                string lastName,
                                string maritalStatus,
                                string hobby,
                                string country,
                                string birthMonth,
                                string birthDay,
                                string birthYear,
                                string phone,
                                string userName,
                                string email,
                                string description,
                                string password,
                                string confirmPassword)
        {
            this.key = key;
            this.firstName = firstName;
            this.lastName = lastName;
            this.maritalStatus = maritalStatus;
            this.hobby = hobby;
            this.country = country;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
            this.birthYear = birthYear;
            this.phone = phone;
            this.userName = userName;
            this.email = email;
            //this.picture = picture;
            this.description = description;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string MaritalStatus
        {
            get { return this.maritalStatus; }
            set { this.maritalStatus = value; }
        }

        public string Hobby
        {
            get { return this.hobby; }
            set { this.hobby = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string BirthMonth
        {
            get { return this.birthMonth; }
            set { this.birthMonth = value; }
        }

        public string BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }

        public string BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        
       // public string Picture
    //    {
      //      get { return this.picture; }
      //      set { this.picture = value; }
      //  }
        

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string ConfirmPassword
        {
            get { return this.confirmPassword; }
            set { this.confirmPassword = value; }
        }

    }
}


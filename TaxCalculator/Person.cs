using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//test for commit
namespace TaxCalculator
{
    class Person
    {

        private string firstName;
        private string surname;
        private string gender;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public Person createPerson(Person person, string firstname, string surname, string gender)
        {
            person.FirstName = firstname;
            person.Surname = surname;
            person.Gender = gender;
            return person;
        }

    }
    class Employee : Person
    {
        private string employeeID;
        private string department;
        private decimal hourlyRate;
        private string email;
        private decimal taxRate;

        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                //randomize employeeID here
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value; // from drop down box
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public decimal HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value; //might need to be changed. Are they fixed??
            }
        }
        public decimal TaxRate
        {
            get
            {
                return taxRate; 
            }
            set
            {
                 //from the rates.txt depending on their weekly wage.
            }
        }
    }
    class Contractor : Employee
    {
        private decimal hoursWorked;
        private const decimal taxRate = 0.20M; // Never changes so assigned as a Constant, also no need for a set TaxRate.

        public decimal HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
            }
        }
        public decimal TaxRate
        {
            get
            {
                return taxRate;
            }
        }
    }
    
}
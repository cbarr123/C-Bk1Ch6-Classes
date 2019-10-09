using System;
using System.Collections.Generic;

namespace list_employees
{
    public class Company
    {
        // Some readonly properties
        public string _companyName{get;}
        public DateTime _dateFounded{get;}

        // Create a public property for holding a list of current employees
        public List<Employee> Employee = new List<Employee>();

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string compName, DateTime dateFormed)
        {
            _companyName = compName;
            _dateFounded = dateFormed;
        }
        //The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
        public void ListEmployees()
        {
            foreach (Employee employee in Employee)
            {

            }
        }



    }
}
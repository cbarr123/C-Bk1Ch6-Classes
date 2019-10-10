using System;

namespace list_employees
{
    class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company TireWorld = new Company("TireWorld", new DateTime(2019-09-30) );

        // Create three employees
        Employee E001 = new Employee();
        {
            E001.firstName = "Thomas";
            E001.lastName = "Beergarten";
            E001.title = "CEO";
            E001.startDate = new DateTime(2019-01-01);
        };
        Employee E002 = new Employee();
        {
            E002.firstName = "Billy";
            E002.lastName = "Thomas";
            E002.title = "Accountant";
            E002.startDate = new DateTime(2018-02-03);
        };
        Employee E003 = new Employee();
        {
            E003.firstName = "Jennifer";
            E003.lastName = "Templeton";
            E003.title = "Warehouse Lead";
            E003.startDate = new DateTime(2017-10-12);
        }

        // Assign the employees to the company
        TireWorld.EmployeeList.Add(E001);
        TireWorld.EmployeeList.Add(E002);
        TireWorld.EmployeeList.Add(E003);

        //Iterate the company's employee list and generate the simple report shown above
        TireWorld.ListEmployees();
        




        
        
    }
}
}

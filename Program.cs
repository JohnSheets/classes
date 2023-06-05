using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
             DateTime currentDateTime = DateTime.Now;
            Company CompanyX = new Company("Company X Inc");
            // CompanyX.Name = "Company X Inc";

            // Create three employees
            Employee employeeOne = new Employee("Mark", "Casto", "Manager", currentDateTime);
            Employee employeeTwo = new Employee("Mary", "Jane", "Hr Rep", currentDateTime);
            Employee employeeThree = new Employee("Tim", "Smith", "Receptionist", currentDateTime);

            // Assign the employees to the company
            CompanyX.ListEmployee(employeeOne);
            CompanyX.ListEmployee(employeeTwo);
            CompanyX.ListEmployee(employeeThree);


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            // Console.WriteLine($"{Employee} {employee.}")
        //      public StartedOn(DateOnly) {
        //     DateTime = StartedOn
        // }

        }
    }
}
using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> EmployeeList { get; set;} = new List<Employee>();
        
         public Company(string name, DateTime date) 
        {
            Name = name;
            CreatedOn = date;        }
         public void ListEmployee(Employee employee)
        {
            EmployeeList.Add(employee);
            Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as a {employee.Title} since {employee.StartedOn}.");
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
//         public class Companyinfo {
//             public Companyinfo(string name, DateOnly date);
//             Name = "CompanyX";
//             DateCreated = 10/20/20;
//         }
 public Company(string name) {
            Name = name;
        }
    }
}
using System;

namespace Classes {
    public class Employee
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Title { get; set;}
        public DateTime StartedOn { get; set;}

        public Employee(string firstname, string lastname, string title, DateTime startedon) {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            StartedOn = startedon;
        }

    }
}

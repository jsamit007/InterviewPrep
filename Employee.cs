using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    internal class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Department { get; set; } = null!;

        public string Designation { get; set; } = null!;

        public decimal Salary { get; set; }

        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName + " " + LastName}, Department: {Department}, Salary {Salary}";
        }
    }

}

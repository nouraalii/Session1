using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel Level { get; set; }
        public double Salary { get; set; }
        public Hiring_Date HireDate { get; set; }
        public string Gender { get; set; } 

        public Employee(int id, string name, SecurityLevel level, double salary, Hiring_Date hireDate, string gender)
        {
            Id = id;

            if (name.Length>=3 && name.Length<20)
            {
                Name = name;
            }

            Level = level;

            if (salary > 0)
            {
                Salary = salary;
            }

            HireDate = hireDate;

            if (gender == "M" || gender == "F")
            {
                Gender = gender;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Security Level: {Level}, Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_task
{
    public abstract class Employee : Workable
    {

        // Properties
        public int Id { get; }
        public string Name { get; }
        private decimal _salary;
        public decimal Salary
        {
            get { 
                return _salary;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Salary cannot be negative.");
                else
                    _salary = value;
            }
        }
        public abstract string EmployeeType { get; }

        // Constructor
        protected Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract decimal CalculateSalary();
        public abstract void Work();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
            Console.WriteLine($"Employee Type: {EmployeeType}");
            Console.WriteLine($"Salary: {Salary:0.##} JOD");
        }
    }
}

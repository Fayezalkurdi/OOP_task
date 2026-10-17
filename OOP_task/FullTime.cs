using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_task
{
    public class FullTime : Employee
    {

        public override string EmployeeType => "FullTime";
        private decimal _monthlySalary;
        public FullTime(int id, string name, decimal monthlySalary)
            : base(id, name)
        {
            _monthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return _monthlySalary;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working fulltime.");
        }
    }
}

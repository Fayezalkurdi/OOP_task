using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_task
{
    public class PartTime : Employee
    {
        private int _hoursWorked;
        private decimal _hourlyRate;

        public override string EmployeeType => "PartTime";

        public PartTime(int id, string name, int hoursWorked, decimal hourlyRate)
            : base(id, name)
        {
            _hoursWorked = hoursWorked;
            _hourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            return _hoursWorked * _hourlyRate;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working parttime.");
        }
    }
}

using OOP_task;

List<Employee> employees = new List<Employee>
{
    new FullTime(1, "Ahmad", 1200),
    new PartTime(2, "Omar", 80, 5)
};

// Polymorphism
foreach (Employee emp in employees)
{
    emp.Salary = emp.CalculateSalary();
}
foreach (Employee emp in employees)
{
    emp.DisplayInfo();
}
foreach (Employee emp in employees)
{
    emp.Work();
}
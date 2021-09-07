using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll!");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeName = "Suchindra";
            employee.Department = ".NET";
            employee.PhoneNumber = "9807654321";
            employee.Address = "Mumbai";
            employee.Gender = 'M';
            employee.BasicPay = 20000.00M;
            employee.Deductions = 2000.00;
            employee.StartDate = Convert.ToDateTime("2021-08-10");

            repo.GetAllEmployee();
        }
    }
}

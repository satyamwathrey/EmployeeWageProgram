using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empolyee Wage Computation Program\n");
            EmpAttendance.GetEmpAttendance();
            EmployeeWage.GetEmpWage();
            PartTimeEmployee.PartTimeWage();
            SwitchCase.DailyEmpWage();
            Console.ReadLine();

        }
    }
}
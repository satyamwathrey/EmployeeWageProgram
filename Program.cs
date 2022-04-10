﻿using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
             //Uc-1 call method
            //EmpAttendance.GetEmpAttendance();

            //Uc-2 call method
            //EmployeeWage.GetEmpWage();

            //Uc-3 call method
            //PartTimeEmployee.PartTimeWage();

            //UC-4 call method
            //SwitchCase.DailyEmpWage();

            //UC-5 call method
            //MonthWages.MonthlyEmpWage();

            //UC-6 call method
            //WageTillCondition.GetWageTillCondition();

            //UC-7 call method
            //RefactorWithClassMethod.RefactorGetMonthlyEmpWage();

            //UC-8 call methods
            //EmpWageForMultipleCompanies.ComputeEmpWage("Google", 20, 2, 10);
            //EmpWageForMultipleCompanies.ComputeEmpWage("Microsoft", 10, 4, 20);
            //EmpWageForMultipleCompanies.ComputeEmpWage("Deloitte", 15, 3, 15);

            //UC-9 call methods
            //SaveTotalWageByCompany google = new SaveTotalWageByCompany("Google", 10, 4, 20);
            //google.TotalWageForEachCompany();
            //Console.WriteLine(google.ToString());

            //SaveTotalWageByCompany microsoft = new SaveTotalWageByCompany("Microsoft", 20, 5, 20);
            //microsoft.TotalWageForEachCompany();
            //Console.WriteLine(microsoft.ToString());

            //SaveTotalWageByCompany deloitte = new SaveTotalWageByCompany("Deloitte", 30, 3, 30);
            //deloitte.TotalWageForEachCompany();
            //Console.WriteLine(deloitte.ToString());

            //UC-10 call methods
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();

            //UC-11 call methods
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            empWageBuilder.ComputeEmpWage();

            
            Console.ReadLine();
        }
    }
}
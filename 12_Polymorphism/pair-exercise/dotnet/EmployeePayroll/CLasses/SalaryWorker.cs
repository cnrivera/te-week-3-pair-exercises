﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    class SalaryWorker : IWorker
    {

        public double AnnualSalary { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            
            return AnnualSalary / 52;

        }
    }
}

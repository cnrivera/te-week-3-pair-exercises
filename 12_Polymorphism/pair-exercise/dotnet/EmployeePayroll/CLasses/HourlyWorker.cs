using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    class HourlyWorker:IWorker
    {
        public double HourlyRate { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            HourlyRate = hourlyRate;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            double pay = 0;
            if (hoursWorked <= 0)
            {
                pay = 0;
            }
            else if (hoursWorked > 40)
            {
                double overtime = hoursWorked - 40;
                pay = HourlyRate * 40;
                pay = pay + (HourlyRate * overtime * .5);

            }
            else
            {
                pay = HourlyRate * hoursWorked;
            }
           
            

            return pay;
        }
    }
}

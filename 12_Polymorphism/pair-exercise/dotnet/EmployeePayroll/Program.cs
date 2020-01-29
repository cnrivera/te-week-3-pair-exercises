using System;
using EmployeePayroll.CLasses;
using System.Collections.Generic;

namespace EmployeePayroll
{
    class Program
    {
    
        static void Main(string[] args)
        {
            List<IWorker> payrollList = new List<IWorker>();

            payrollList.Add(new VolunteerWorker("Mother", "Theresa"));

            payrollList.Add(new HourlyWorker(15, "Donald", "Duck"));

            payrollList.Add(new SalaryWorker(42000, "Mickey", "Mouse"));

            var rand = new Random();
            int hoursWorked;
            int totalHours = 0;
            double totalPay = 0;


            Console.WriteLine("{0, -20} {1, 5} {2, 10}", "Employee", "Hours Worked", "Pay");
            Console.WriteLine("=====================================================================");

            foreach (IWorker worker in payrollList)
            {
                hoursWorked = rand.Next(110);
                totalHours += hoursWorked;
                totalPay += worker.CalculateWeeklyPay(hoursWorked);
                Console.WriteLine("{0, -20} {1, 6} {2, 18:C}", worker.LastName + ", " + worker.FirstName, hoursWorked, worker.CalculateWeeklyPay(hoursWorked));
                    
            }
            Console.WriteLine("");
            Console.WriteLine($"Total Hours: {totalHours}");
            Console.WriteLine("Total Pay: "+"{0:C}", totalPay);



        }


        
    }
}

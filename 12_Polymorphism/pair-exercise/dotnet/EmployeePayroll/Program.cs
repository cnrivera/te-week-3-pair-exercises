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


            Console.WriteLine("Employee \t\t\tHours Worked \t\t\tPay");
            Console.WriteLine("=====================================================================");

            foreach (IWorker worker in payrollList)
            {
                hoursWorked = rand.Next(110);
                totalHours += hoursWorked;
                totalPay += worker.CalculateWeeklyPay(hoursWorked);
                Console.WriteLine($"{worker.LastName}, {worker.FirstName} \t\t\t{hoursWorked} \t\t\t${Math.Round(worker.CalculateWeeklyPay(hoursWorked))}");
                    
            }
            Console.WriteLine($"Total Hours: {totalHours}");
            Console.WriteLine($"Total Pay: ${Math.Round(totalPay)}");



        }


        
    }
}

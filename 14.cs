using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
        class Employees
        {
            private double salary;

            public void SetSalary(double amount)
            {
                if (amount > 0)
                {
                    salary = amount;
                }
                else
                {
                    Console.WriteLine("Invalid Salary");
                }
            }

            public double GetSalary()
            {
                return salary;
            }
        }

       public class _14
        {
            public static void _14Main()
            {
                Employees emp = new Employees();
                Console.WriteLine("Enter Employee Salary: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                emp.SetSalary(amount);
                Console.WriteLine("Employee Salary is: " + emp.GetSalary());
            }
        }
    }


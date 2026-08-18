using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
    class Employee1
    {
       public int EmployeeID { get; set; }

       public string Name { get; set; }

       public int BasicSalary { get; set; }
    }

    class PermanentEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double HRA = BasicSalary * 0.20;
            double DA = BasicSalary * 0.10;
            double netSalary = BasicSalary + HRA + DA;
            Console.WriteLine("--------Permanent Employee Details--------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class ContractEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double netSalary = BasicSalary;

            Console.WriteLine("\n--------Contract Employee Details--------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ID: " + EmployeeID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + netSalary);
        }
    }

    public class _16
    {
        public static void _16Main()
        {
            PermanentEmployee p = new PermanentEmployee();

            p.EmployeeID = 101;
            p.Name = "Viraj";
            p.BasicSalary = 50000;

            p.CalculateSalary();

            ContractEmployee c = new ContractEmployee();

            c.EmployeeID = 102;
            c.Name = "Khush";
            c.BasicSalary = 30000;

            c.CalculateSalary();

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.builder;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name = "Ivan",Salary = 120},
                new Employee{Name="Boris",Salary = 80},
                new Employee{Name="Misha",Salary=33}
            };

            var builder = new EmployeeReportBuilder(employees);

            var director = new EmployeeReportDirector(builder);

            director.Build();


            var report = builder.GetReport();

            Console.WriteLine(report);
            Console.ReadLine();
        }
    }
}

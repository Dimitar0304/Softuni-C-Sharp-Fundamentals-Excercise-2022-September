using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            //first line we recive number of employees
            int n = int.Parse(Console.ReadLine());
            string bestDepartment = string.Empty;
            decimal bestAvr = 0m;
            Dictionary<string, decimal> departmentIncome = new Dictionary<string, decimal>();
            Dictionary<string, int> departmentMembers = new Dictionary<string, int>();

            // with for loop we indicates their names,salaries and department
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] empInfo = Console.ReadLine().Split();
                string name = empInfo[0];
                decimal salary = decimal.Parse(empInfo[1]);
                string department = empInfo[2];
                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);
            }

            for (int e = 0; e < employees.Count; e++)
            {
                if (!departmentIncome.ContainsKey(employees[e].Department))
                {
                    departmentIncome[employees[e].Department] = 0;
                    departmentMembers[employees[e].Department] = 0;
                }
                if (employees[e].Department == employees[e].Department)
                {
                    departmentMembers[employees[e].Department] += 1;
                    departmentIncome[employees[e].Department] += employees[e].Salary;
                }
                
            }
            foreach (var kvp in departmentIncome)
            {
                string currentDep = kvp.Key;
                decimal currentSalaryies = kvp.Value;
                int currentDepMEmbers = departmentMembers[currentDep];
                decimal currentAvvrg = currentSalaryies / currentDepMEmbers;
                if (bestAvr < currentAvvrg)
                {
                    bestAvr = currentAvvrg;
                    bestDepartment = currentDep;
                }

            }
            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (var emp in employees.Where(e=>e.Department==bestDepartment).OrderByDescending(e=>e.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:F2}");
            }
            
            //calculate department with the highest avarage salary and print the department
            // and their members with name and salary
            //the salary is rounded 2 digit after decimal point

        }
        class Employee
        {
            public Employee(string name,decimal salary,string department)
            {
                Name = name;
                Salary = salary;
                Department = department;
            }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
        }
    }
}

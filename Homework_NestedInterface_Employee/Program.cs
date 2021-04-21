using System;
using System.Collections.Generic;

namespace Homework_NestedInterface_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Employee> employees = new List<Employee>();
            Department department = new Department();
            Employee employee = new Employee();
            department.AddEmployee(employee);

            Employee employee1 = new Employee();
            department.AddEmployee(employee1);
            //employees.Add(employee);
            //employee.InputName();
            //employee.InputSalary();
            //employee.PrintEmployee();
            Employee employee_clone = (Employee)employee.Clone();
            //department.AddEmployee(employee_clone); // !!! як клонований обєкт помістити в ліст???
            //employees.Add(employee_clone);
            //employee_clone.InputName();
            //employee_clone.InputSalary();
            employee_clone.PrintEmployee();
            //Console.Clear();
            //department.Print();
            //department.DeleteEmployee(employee1);
            department.Print();

            double avg_salary = default;
            int sum_salary = default;
            int num = default;

            foreach (var item in department.employees)
            {
                Console.WriteLine($"{item.Salary}");
                sum_salary += item.Salary;
                num++;
            }
            avg_salary = sum_salary / num; // середня зарплата
            Console.WriteLine($"Avarage salary: {avg_salary} usd");
            Console.WriteLine();

            foreach (Employee emp in department) // вивід інформації через foreach, з викорстанням GetEnumerator() в класі Department
            {
                emp.PrintEmployee();
            }
        }
    }
}

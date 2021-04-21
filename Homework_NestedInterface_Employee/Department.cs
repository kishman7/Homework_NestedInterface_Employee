using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework_NestedInterface_Employee
{
    class Department : IEnumerable   // ЯК В ПОТОЧНІЙ ЗАДАЧІ ВИКОРИСТАТИ IEnumerable???
    {
        public List<Employee> employees = new List<Employee>();
        //public Employee employee = new Employee();

        public void AddEmployee(Employee employee) // додаємо працівника
        {
            employee.InputName(); // вводимо імя працівника
            employee.InputSalary(); // вводимо ЗП працівника
            employees.Add(employee); // Додаємо працівника
            Console.WriteLine();
        }

        public void DeleteEmployee(Employee employee) // Видалення працівника по ID
        {
            Console.WriteLine("Enter the ID of the employee you want to delete: ");
            int delete_ID = int.Parse(Console.ReadLine());
            if (delete_ID == employee.Count-1)
            {
                employees.RemoveAt(delete_ID - 1);
            }

        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)employees).GetEnumerator();  //перелічувач, який використовується для List employees
        }

        public void Print() // вивід працівників на екран
        {
            foreach (var item in employees)
            {
                item.PrintEmployee();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_NestedInterface_Employee
{
    class Employee : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public static int ID { get;
            set; } = 0;
        public int Count { get; set; } = 0;

        public Employee() 
        {
            ID++;
            Count = ID;
        }
        public bool NotNumber(string str) //метод на перевірку чисел в рядку
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"^[a-zA-Z]+$"); // регулярний вираз (на перевірку числа в рядку)
        }
        public void InputName() // вводимо імя
        {
            Console.WriteLine("Enter first name employee: ");
            this.FirstName = Console.ReadLine();
            if (!NotNumber(this.FirstName)) // перевіряємо чи введений рядок має числа
            {
                Console.WriteLine("Not format FirstName!"); // якщо є числа, то виводиться повідомлення
                InputName(); // якщо не ма чисел, записуємо значення
            }

            Console.WriteLine("Enter last name employee: ");
            this.LastName = Console.ReadLine();
            if (!NotNumber(this.LastName))
            {
                Console.WriteLine("Not format LastName!");
                InputName();
            }
            Console.WriteLine($"Name employee: {this.FirstName} {this.LastName}");
        }

        public void InputSalary() // вводимо зарплату
        {
            Console.WriteLine("Enter salary employee: ");
            try
            {
                checked // перевірка чи перевищує значення максимального значення по типу, якщо так то викене Exception, checked не працює???
                { this.Salary = int.Parse(Console.ReadLine()); }    // здійснити перевірку на написання символів!!!
                Console.WriteLine($"Salary employee: {this.Salary} usd");
            }
            catch (Exception)
            {
                Console.WriteLine("Great value!");
            }

        }

        public void AddSalary(int add) // збільшення зарплати
        {
            try
            {
                checked // перевірка чи перевищує значення максимального значення по типу, якщо так то викене Exception
                { this.Salary += add; }
                Console.WriteLine($"Salary after increase: {this.Salary} usd");
            }
            catch (Exception)
            {
                Console.WriteLine("Great value!");
            }
        }

        public void PrintEmployee()
        {
            Console.WriteLine($"ID: {Count}\nFirst Name: {this.FirstName}\nLast Name: {this.LastName}\nSalary: {this.Salary} usd");
        }

        public object Clone() // реалізовує метод клонування
        {
            Employee emp = new Employee();
            emp.FirstName = this.FirstName;
            emp.LastName = this.LastName;
            emp.Salary = this.Salary;
            emp.Position = this.Position;
            return emp;
        }
    }
}

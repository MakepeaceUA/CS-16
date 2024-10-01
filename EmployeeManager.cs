using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class EmployeeManager
    {
        private List<Employee> employee = new List<Employee>();
        public void AddEmployee(Employee em)
        {
            employee.Add(em);
            Console.WriteLine("Работник добавлен.");
        }
        public void RemoveEmployee(string fullName)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].FullName == fullName)
                {
                    employee.RemoveAt(i);
                    Console.WriteLine("Работник добавлен.");
                    return;
                }
            }
            Console.WriteLine("Работник не найден.");
        }
        public void UpdateEmployee(string fullName, string newPosition, decimal newSalary, string newEmail)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].FullName == fullName)
                {
                    employee[i].Position = newPosition;
                    employee[i].Salary = newSalary;
                    employee[i].Email = newEmail;
                    Console.WriteLine("Информация обновлена.");
                    return;
                }
            }
            Console.WriteLine("Работник не найден.");
        }
        public void SearchName(string fullName)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].FullName == fullName)
                {
                    Console.WriteLine(employee[i].ToString());
                    return;
                }
            }
            Console.WriteLine("Работник не найден.");
        }
        public void SearchPosition(string position)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].Position == position)
                {
                    Console.WriteLine(employee[i].ToString());
                    return;
                }
            }
            Console.WriteLine("Работник не найден.");
        }
        public void SortSalary()
        {
            for (int i = 0; i < employee.Count - 1; i++)
            {
                for (int j = i + 1; j < employee.Count; j++)
                {
                    if (employee[i].Salary > employee[j].Salary)
                    {
                        var temp = employee[i];
                        employee[i] = employee[j];
                        employee[j] = temp;
                    }
                }
            }
            Console.WriteLine();
        }
        public void SortName()
        {
            for (int i = 0; i < employee.Count - 1; i++)
            {
                for (int j = i + 1; j < employee.Count; j++)
                {
                    if (string.Compare(employee[i].FullName, employee[j].FullName) > 0)
                    {
                        var temp = employee[i];
                        employee[i] = employee[j];
                        employee[j] = temp;
                    }
                }
            }
        }
        public void SortPosition()
        {
            for (int i = 0; i < employee.Count - 1; i++)
            {
                for (int j = i + 1; j < employee.Count; j++)
                {
                    if (string.Compare(employee[i].Position, employee[j].Position) > 0)
                    {
                        var temp = employee[i];
                        employee[i] = employee[j];
                        employee[j] = temp;
                    }
                }
            }
        }
            public void Info()
        {
            foreach (var em in employee)
            {
                Console.WriteLine(em.ToString());
            }
        }
    }
}

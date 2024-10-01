using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class EmployeeInfo
    {
        private Dictionary<string, string> Data = new Dictionary<string, string>();

        public void AddEmployee(string login, string password)
        {
            if (!Data.ContainsKey(login))
            {
                Data.Add(login, password);
                Console.WriteLine($"Работник с логином {login} добавлен.");
            }
            else
            {
                Console.WriteLine($"Логин {login} занят.");
            }
        }
        public void RemoveEmployee(string login)
        {
            if (Data.ContainsKey(login))
            {
                Data.Remove(login);
                Console.WriteLine($"Работник с логином {login} удалён.");
            }
            else
            {
                Console.WriteLine($"Логин {login} не найден.");
            }
        }
        public void UpdatePassword(string login, string newPassword)
        {
            if (Data.ContainsKey(login))
            {
                Data[login] = newPassword;
                Console.WriteLine($"Пароль для логина {login} обновлён.");
            }
            else
            {
                Console.WriteLine($"Логин {login} не найден.");
            }
        }
        public void UpdateLogin(string oldLogin, string newLogin)
        {
            if (Data.ContainsKey(oldLogin))
            {
                if (!Data.ContainsKey(newLogin))
                {
                    string password = Data[oldLogin]; 
                    Data.Remove(oldLogin);
                    Data.Add(newLogin, password); 
                    Console.WriteLine($"Логин {oldLogin} изменён на {newLogin}.");
                }
                else
                {
                    Console.WriteLine($"Логин {newLogin} занят.");
                }
            }
            else
            {
                Console.WriteLine($"Логин {oldLogin} найден.");
            }
        }

        public string LoginPassword(string login)
        {
            if (Data.ContainsKey(login))
            {
                return $"Пароль для логина {login}: {Data[login]}";
            }
            else
            {
                return $"Логин {login} не найден.";
            }
        }
        public void DisplayInfo()
        {
            if (Data.Count > 0)
            {
                foreach (var employee in Data)
                {
                    Console.WriteLine($"Логин: {employee.Key}, Пароль: {employee.Value}");
                }
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
        }
    }
}

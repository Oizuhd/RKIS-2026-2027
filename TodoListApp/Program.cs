using System;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнили Сотник и Шпак");
            Console.WriteLine("Ведите своё имя пожалуйста: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ведите свою фамилию пожалуйста: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Ведите свой год рождения пожалуйста: ");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Добавлен пользователь: {name} {surname} возраст: {2026-year}");
            
            string[] todos = new string[2];
            int count = 0;
            while (true)
            {
                Console.WriteLine("Команды: add, view, help, exit");
                string command = Console.ReadLine();
                if (command == "help")
                {    
                    Console.WriteLine("profile - выводит данные пользователя");
                    Console.WriteLine("add - добавляет новую задачу");
                    Console.WriteLine("view -  выводит все задачи из массива");
                    Console.WriteLine("exit - завершает цикл и останавливает выполнение программы");
                }
                else if (command.StartsWith("add "))
                {
                    string[] parts = command.Split('"');
                    string task = parts[1];

                    if (count == todos.Length)
                    {
                        string[] newTodos = new string[todos.Length * 2];
                        for (int i = 0; i < count; i++)
                        {
                            newTodos[i] = todos[i];
                        }
                        todos = newTodos;
                    }
                    todos[count] = task;
                    count++;
                    Console.WriteLine("Задача добавлена");
                }
                else if (command == "profile")
                {
                    Console.WriteLine($"Имя: {name}");
                    Console.WriteLine($"Фамилия: {surname}");
                    Console.WriteLine($"Год: {year}");
                }
                else if (command == "view")
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(todos[i]);
                    }
                }
                else if (command == "exit")
                {
                    break;
                }
            }
        }
    }
}

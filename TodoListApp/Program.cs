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
            while (true)
            {
                Console.WriteLine("Команды: add, view, help, exit");
                string command = Console.ReadLine() "";
                if (command == "help");
                {    
                    Console.WriteLine("profile - выводит данные пользователя");
                    Console.WriteLine("add - добавляет новую задачу");
                    Console.WriteLine("view -  выводит все задачи из массива");
                    Console.WriteLine("exit - завершает цикл и останавливает выполнение программы");
                }
                
            }
        }
    }
}

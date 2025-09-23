// See https://aka.ms/new-console-template for more information
using MyCSharpProject.Models; // Подключаем наше пространство имён

Console.WriteLine("Привет! Это моя первая программа на C#!");

// Создаем объект человека
Person person = new Person { Name = "Алексей", Age = 25 };

// Выводим информацию о нем
Console.WriteLine($"Создан человек: {person.Name}, возраст: {person.Age}");

Console.WriteLine("Программа завершена. Нажмите любую клавишу...");
Console.ReadKey(); // Чтобы консоль не закрылась сразу
// Главная точка входа в приложение
// Настраивает контейнер зависимостей (DI)
// Конфигурирует middleware pipeline
// Запускает веб-хост или консольное приложение
using MyCompany.Models;

Console.WriteLine("Привет! Это моя первая программа на C#!");

// Создаем объект человека
Person person = new Person { Name = "Алексей", Age = 25 };

// Выводим информацию о нем
Console.WriteLine($"Создан человек: {person.Name}, возраст: {person.Age}");

Console.WriteLine("Программа завершена. Нажмите любую клавишу...");
Console.ReadKey(); // Чтобы консоль не закрылась сразу
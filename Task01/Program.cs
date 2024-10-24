using System;
using MyCustomDictionary;  // Простір імен з бібліотеки класів

namespace MyDictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра MyDictionary
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            // Додавання елементів
            myDictionary.Add("One", 1);
            myDictionary.Add("Two", 2);
            myDictionary.Add("Three", 3);

            // Використання індексатора для отримання значення за ключем
            Console.WriteLine("Значення для ключа 'Two': " + myDictionary["Two"]);

            // Отримання загальної кількості елементів
            Console.WriteLine("Загальна кількість елементів: " + myDictionary.Count);

            // Перебір елементів за допомогою foreach
            Console.WriteLine("Елементи MyDictionary:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Ключ: {kvp.Key}, Значення: {kvp.Value}");
            }
        }
    }
}



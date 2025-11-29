using System;
using System.IO;
using System.Text.Json;
namespace Serialization
{
    // Описываем наш класс и помечаем его атрибутом для последующей сериализации
    [Serializable]
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Объект для сериализации
            var pet = new Pet("Rex", 2);
            Console.WriteLine("Объект создан");

            // Сериализация
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(pet, options);
            File.WriteAllText("myPets.json", jsonString);
            Console.WriteLine("Объект сериализован");

            // Десериализация
            jsonString = File.ReadAllText("myPets.json");
            var newPet = JsonSerializer.Deserialize<Pet>(jsonString);
            Console.WriteLine("Объект десериализован");

            Console.WriteLine($"Имя: {newPet.Name} --- Возраст: {newPet.Age}");
            Console.ReadLine();
        }
    }
}

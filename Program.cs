using System;
using System.IO;

namespace csharp_learning{

    class Program{
        
        static void Main() {
          // Создаем объект. Он имеет доступен ко всем характеристикам класса.
            Class_learn bot = new Class_learn();
            bot.name = "Bot";
            bot.weight = 800;
            bot.coordinates = new byte [] {0, 0, 0};
            System.Console.WriteLine(bot.name + " Weight:" + bot.weight);

          // Создаем другой объект на основе того же самого класса.
            Class_learn killer = new Class_learn();
            killer.name = "Killer";
            killer.weight = 1000;
            killer.coordinates = new byte [] {0, 0, 10};
          
          // Можем вызывать методы класса.
          Class_learn bee = new Class_learn();
          bee.setValues("Bee", 50, new byte[] {0, 0, 0});
          bee.printValue();

          //Объект класса, который будет создаваться на основе конструктора, который принимаем переменные.
          Class_learn car = new Class_learn("Car", 10, new byte []{1, 1, 1});
          car.printValue();

          //Обращаемся к переменной static. Сразу через класс, а не его объекты.
          Class_learn.count = 5;
          Class_learn.Print();

          // Использование акссессора
          car.Weight = -100;
          System.Console.WriteLine(car.Weight);
       }
    }    
}

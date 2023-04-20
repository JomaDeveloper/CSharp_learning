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
          bot.printValue();
          
       }
    }    
}

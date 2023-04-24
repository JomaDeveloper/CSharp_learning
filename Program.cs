using System;
using System.IO;
using System.Collections.Generic;

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

          // Создаем объект на основе класса Killer, которые является наследником первого - Class_learn.
          Killer killer_bot = new Killer();
          killer_bot.setValues("Killer_v2", 1000, new byte[] {10, 10, 10});
          killer_bot.printValue();
          //killer_bot.Health = 100;
          killer_bot.Lazer();

          Killer assasin = new Killer("Assasin", 1000, new byte[] {0, 1, 0}, 20);

          // as позволяет обрабатывать объект как родительский (к другому классу).
          // is позволяет проверить принадлежность к определенному типу данных.
          List<Killer> robots = new List<Killer>();
          robots.Add(new Killer("Alex", 400, new byte[] {30, 1, 0}, 20));
          robots.Add(new Killer("Bob", 200, new byte[] {10, 1, 0}, 30));
          robots.Add(new Killer("Sesh", 100, new byte[] {0, 11, 0}, 40));
          robots.Add(new Killer("Carl", 600, new byte[] {0, 1, 20}, 50));

          Class_learn newRobot = null;
          foreach(Killer obj in robots){
            if(obj.Name == "John"){
              newRobot = obj as Class_learn;
            }
            System.Console.WriteLine(obj is Class_learn);
          }

       }
    }    
}

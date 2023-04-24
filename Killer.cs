using System;

namespace csharp_learning{

    // Создаем новый класс на основе другого класса.
    // В нем есть все от родительского.
    class Killer: Class_learn {

        public int Health { get; set; }

        // Конструкторы
        public Killer(){}

        // С помощью base(args) мы обращаемся к родительскому классу и передаем ему поля.
        // Он ищет совпадние, под которое попадает родительские констуркторы.
        // Также если мы хотим использовать методы из родительского класса, то лучше прописывать base.method()
        public Killer(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates) {
            this.Health = health;
            base.printValue();
        }

        public void Lazer(){
            System.Console.WriteLine("Lazer shooting");
        }
         
    }

}
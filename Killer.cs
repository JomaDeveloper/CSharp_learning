using System;

namespace csharp_learning{

    //Перечисление. Всегда имеем удобный формат для использрвания.
    enum Typpe { Enemy, Hero, Traitor }

    // Создаем новый класс на основе другого класса.
    // В нем есть все от родительского.
    class Killer: Class_learn {

        public int Health { get; set; }

        public Typpe type;

        // Конструкторы
        public Killer(){}

        // С помощью base(args) мы обращаемся к родительскому классу и передаем ему поля.
        // Он ищет совпадние, под которое попадает родительские констуркторы.
        // Также если мы хотим использовать методы из родительского класса, то лучше прописывать base.method()
        public Killer(string name, int weight, byte[] coordinates, int health, Typpe type) : base(name, weight, coordinates) {
            this.Health = health;
            this.type = type;
        }

        // Использование с enum
        public Killer(string name, int weight, byte[] coordinates, int health, Typpe type) : base(name, weight, coordinates) {
            this.Health = health;
            this.type = type;
        }

        // Переписывает виртуальный метод, который находится в классе-родителе. 
        public override void printValue()
        {
            base.printValue();
            System.Console.WriteLine("Health: " + this.Health);
        }

        public void Lazer(){
            System.Console.WriteLine("Lazer shooting");
        }
         
    }

}
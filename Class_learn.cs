using System;

namespace csharp_learning{

    class Class_learn{

        // Static у поля или у метода обозначает, что мы сразу имеем доступ через класс, а не объекты.
        // То есть это никак не связано с объектами, сразу через класс.
        // Например -> Class_learn.count = 5;
        public static int count;
        public static void Print(){
            System.Console.WriteLine("Count is {0}", count);
        }

        //Описываем чертеж, общую хааректристику для объектов.

        //Модификатор доступа -> public, protected, private etc.
        // public - переменная будет доступа везде: внутри своего класса и других.
        // protected - переменная будет доступна исключительно внутри этого класса, а также в классах-наследниках.
        // private - данное поле будет доступен исключительно в этом классе. 
        // private по большей части нужен из-за инкапсуляции, чтобы переменные были доступны только в классе.

        // Конструктор. Действия при создании объекта. Название должно быть то же, что и название класса.
        // Может создавать сколько угодно конструкторов.
        public Class_learn(string _name, int _weight, byte[] _coordinates){
            System.Console.WriteLine("Object has been created");
            setValues(_name, _weight, _coordinates);
            count++;
        }
        // Второй констуктор, который будет срабатывать, если не указывать параметры.
        public Class_learn(){
            count++;
        }

        // Переменные характеристик объектов класса.
        public string name;
        public int weight;
        public byte[] coordinates;

        // Если мы создадим функцию, то каждый объект, созданный на основе этого класса, будет иметь доступ к этой функции. 
        public void setValues(string _name, int _weight, byte[] _coordinates){
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }

        public void printValue(){
            System.Console.WriteLine(name + " weight:" + weight + ". Coordinates: ");
            foreach(byte el in coordinates){
                System.Console.WriteLine(el);
            }
        }


    }

}
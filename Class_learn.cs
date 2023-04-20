using System;

namespace csharp_learning{

    class Class_learn{

        //Описываем чертеж, общую хааректристику для объектов.

        //Модификатор доступа -> public, protected, private etc.
        // public - переменная будет доступа везде: внутри своего класса и других.
        // protected - переменная будет доступна исключительно внутри этого класса, а также в классах-наследниках.
        // private - данное поле будет доступен исключительно в этом классе. 
        // private по большей части нужен из-за инкапсуляции, чтобы переменные были доступны только в классе.

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
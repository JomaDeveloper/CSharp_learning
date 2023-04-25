using System;

namespace csharp_learning{

    class Class_learn:{

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
            //System.Console.WriteLine("Object has been created");
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

        // Аксессоры позволяют нам вытаскивать информацию по полю.
        // Не явлсяется ни констурктором, ни методом.
        // Получаем дополнительный набор возможностей.
        public int Weight{
            get{
                System.Console.WriteLine("Результат: ");
                return this.weight;
            }
            set{
                if(value < 1)
                    this.weight = 1;
                else
                    this.weight = value; // value нигде не фигурирует, по умолчанию пытается установить внутри акссесора.
            }
        }

        public string Name{
            get{
                return this.name;
            }
             private set{}
        }

        //Акссесоры могут быть без полей, но с ними можно взаимодействовать.
        // Это отдельное поле с разной установкой доступа.
        // Например, допускает установке, но не получение через get/ 
        public int Width{ private get; set; }

        // Если мы создадим функцию, то каждый объект, созданный на основе этого класса, будет иметь доступ к этой функции. 
        public void setValues(string _name, int _weight, byte[] _coordinates){
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }

        // Нельзя указывать идентичные названия параметров как в полей класса. Нельзя называть параметр функции name или eight, как у класса.
        // Компилятор не понимает, что к чему мы пытаемся присвоить.
        // Но мы можем использовать this, который говорит, что мы обращаемся к этому же классу.
        // Компилятор понимает, что мы обращаемся к классу поля и присваем стороннее значение параметра.
        // Обычно его еще используют при методах, чтобы показать, что он явно в данном классе, а не другому.
        // Например  this.setValues(_name, _weight, _coordinates);
        // this НЕЛЬЗЯ принимать вместе со статическим модификатором (static) из-за того, что this работает с полями и методами, 
        // которые принадлежат к объектам, а не к класуу в целом в отличие от static, которые относит поле или метод к классу в целом.

        public void setValues_v2(string name, int weight, byte[] coordinates){
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        // virtual обозначает, что это виртуальный метод, а значит, что мы можем переписать его функционал в классе-наследнике.
        public virtual void  printValue(){
            System.Console.WriteLine(name + " weight:" + weight + ". Coordinates: ");
            foreach(byte el in coordinates){
                System.Console.WriteLine(el);
            }
        }


    }

}
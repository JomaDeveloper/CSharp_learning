using System;
using System.Collections.Generic;

namespace csharp_learning{

    class Program{
        
        static void Main() {
          short[] nums = {1, 2, 3, 4, 5};

          // удобен при работе с двумерными массивами тоже, он перебирает каждый элемент массива в массиве тоже.
          foreach(short el in nums){
            Console.WriteLine(el);
          }

          // Динамические массивы позволяют не указывать точное количество элементов массива.
          // На его обработку уходит больше ресурсов.
          // Необходимо использовать using System.Collections.Generic;
          List<int> numbers = new List<int> (){
            4, 6, 7
          };
          numbers.Add(40);
          numbers.Remove(40);
          numbers.Sort();
          numbers.Reverse();
          numbers.Clear();
          numbers.Contains(0); // True or False

          foreach(int i in numbers){
            Console.WriteLine(i);
          }



      }


    }
        
}

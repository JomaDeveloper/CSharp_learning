using System;
using System.Collections.Generic;

namespace csharp_learning{

    class Program{
        
        static void Main() {
          int res_1 = Summa_2(1,2);
          Console.WriteLine(res_1.ToString());

          byte[] nums = {5, 6, 7};
          byte res_2 = Ssum(nums);
          Console.WriteLine("Результат: " + res_2);
        }

        // Декларируя public, мы обозначаем, что может обращаться к этой функции во всех классах, а не только Program.
        // Static говорит о том, что мы сможет обращаться к этой функции просто через название класса, а не создавать объект
        // на основе этого класса.
        // Void означает, что функция ничего не возвращает.
        public static void Print(string word = "Hi"){
          Console.WriteLine(word);
        }

        public static void Summa(int x, int y){
          int res = x + y;
          Print("результат: " + res);
        }

        // Данная функция возвращает int
        public static int Summa_2(int x, int y){
          return x + y;
        }

        public static byte Ssum(byte[] digits){
          byte summ = 0;
          foreach(byte el in digits){
            summ += el;
          }
          
          return summ;
        }


    }
        
}

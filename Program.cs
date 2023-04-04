using System;

namespace csharp_learning{

    class Program{
        
        static void Main() {
           
            int a = 3;
            string word = "hello";
            bool isHappy = true; 

            if(a > 7) { 
                Console.WriteLine("1");
            } else if(a < 5 && isHappy) // && - and; || - or
                Console.WriteLine("2"); // Если после условия 1 строчка кода, то можно не ставить {}.
            else {
                Console.WriteLine("3");
            }

        }

    }

}
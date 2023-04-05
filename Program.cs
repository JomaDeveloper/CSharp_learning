using System;

namespace csharp_learning{

    class Program{
        
        static void Main() {

            // for(float i = 200; i > 10; i /= 2){
            //     Console.WriteLine("Element: {0}", i);
            // }
            
            // int i = 0;
            // while (i < 10){
            //     Console.WriteLine("Element: {0}", i);
            //     i++;
            // }

            // bool isHasCar = true;
            // string end;
            // while (isHasCar){
            //     Console.WriteLine("+");
            //     end = Console.ReadLine();
            //     if (end == "end")
            //         isHasCar = false;
            //     else if (end == "p")
            //         break;
            // }


            // Do-While. At first it launches Do then check condition in While.
            // Do will process one time for sure.
            byte i = 100;
            do{
              Console.WriteLine("Element {0}", i);  
            } while(i < 10);
           

           }


        }

    }

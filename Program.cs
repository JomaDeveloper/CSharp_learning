using System;

namespace csharp_learning{

    class Program{
        
        static void Main() {
           // Switch-case like conditional operator.
           // But we can only check equality of the variable.
           // But it can me useful when we expect a lot of inputs that needs variable checking.
           // We can easily do it via if-else.
           short user_input = Convert.ToInt16(Console.ReadLine());

           switch(user_input) {
                case 5: //Code until a must-have break;
                    Console.WriteLine("Number is 5"); 
                    break;
                case 10: //Code until a must-have break;
                    Console.WriteLine("Number is 10"); 
                    break;
                case 15: //Code until a must-have break;
                    Console.WriteLine("Number is 15"); 
                    break;
                case 20: //Code until a must-have break;
                    Console.WriteLine("Number is 20"); 
                    break;
                default: // Like else
                    Console.WriteLine("Number is unrecognized!"); 
                    break; 
           }


        }

    }

}
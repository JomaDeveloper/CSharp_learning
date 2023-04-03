using System;

namespace csharp_learning{

    class Program{
        
        static void Main() {
            // int number;
            // number = 0;

            int number = 10; // Declare the variable with integer type.
            Console.WriteLine(number);
            number = 0; //We can change this variable.
            string word = "Variable: ";
            // Console.WriteLine("Variable:" + number);
            Console.WriteLine(word + number);

            //Variable types
            // uint - only positive numbers.
            // byte - number until 255 or -255. Integer type require more operational memory than byte.
            // short - number in a range until 32650?. Less memory than int but more than byte.
            // long - more than int.

            //float - decimal numbers. It is important to add "f" at the end of the number like float num = 4.545f;

            //string - for text. string word = "Hello";
            //char - for a 1 symbol. char symbol = 's';

            //bool - False or True. bool isHappy = true; They are used mostly in loops or conditionals(if).

            int num1 = 0, num2 = 0; //We can declare multiple variables.
            num1 = Convert.ToInt32(Console.ReadLine()); //Everything that comes from user in Terminal has the type of string even if it is a number.
            num2 = Convert.ToInt32(Console.ReadLine()); //Everything that comes from user in Terminal has the type of string even if it is a number.
            Console.WriteLine("First:" + num1);
            Console.WriteLine("Second:" + num2);
        }

    }

}
using System;

namespace csharp_learning{

    class Program{
        
        static void Main() {
            //Converting data types
            Console.Write("Введите число с точкой: ");
            float user_input = (float)Convert.ToDouble(Console.ReadLine());
            // float user_input = float.Parse(Console.ReadLine());

            //Maths Operations
            float result;
            result = user_input + 10f;
            // result = user_input - 15f;
            // result = user_input * 15f;
            // result = user_input / 5f;
            // result = user_input % 10f;
            // result *= 2f
            // result++ or result --

            Console.WriteLine("Переменная: " + result);

        }

    }

}

/* In C#, an explicit cast is a way to convert a value of one type to another type, 
but with the possibility of data loss or exceptions. When an explicit cast is used, 
the compiler requires that the cast be explicitly stated in the code.

An explicit cast is used to convert a value from a larger data type to a smaller one, 
or from one data type to another that is not implicitly convertible. 
For example, you might use an explicit cast to convert a double to a float, or an int to a short.

Here's an example of how to use an explicit cast in C#:

double d = 3.14159;
float f = (float)d; // Explicit cast from double to float
In this example, the value of the double variable d is converted to a float using an explicit cast. 
Since a float has a smaller range and precision than a double, some data loss may occur during the conversion.

It's important to note that if the value being cast cannot be represented by the target data type, 
an exception will be thrown at runtime. For example, if you try to cast a value of 1000000000000 to an int, 
an OverflowException will be thrown, because the value is too large to fit in an int.
*/
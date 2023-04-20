using System;


namespace csharp_learning{

    class TryC{

        static void Main_add() {
        
            // try{
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine(num);
            // } catch(FormatException){
            //     System.Console.WriteLine("Wrong type of variable");
            // }
          
            try{
                int a, b, res;
                System.Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                System.Console.WriteLine("Результат: {0}", res);
            } catch(System.DivideByZeroException){
                System.Console.WriteLine("Деление на ноль");
            } catch(FormatException){
                System.Console.WriteLine("Не тот формат");
            } finally{
                
            }
            

       }
    }    
}
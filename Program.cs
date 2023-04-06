using System;

namespace csharp_learning{

    class Program{
        
        static void Main() {
          // [] указывает, что мы хотим создать массив.
          //Мы обязаны указывать тут значения или указывать сколько памяти выделять на массив.
          // Указание памяти new byte[5]. 
          // Массив стал содержать 5 элементов, но у них нет никакого значения.
          byte[] nums = new byte[5];
          nums[0] = 250;
          nums[1] = 50;
          nums[2] = 20;
          nums[3] = 100;
          nums[4] = 25;
          Console.WriteLine("Element: {0}", nums);

          //Присваиваем значения прямо при создании массива
          string[] words = new string[] {"John", "Bob", "Alex"};
          words[1] = "Josh";
          for (byte i = 0; i < words.Length; i++)
            Console.WriteLine("Element: {0}: {1}", i, words[i]);

          short[] numbers = new short[5];
          short sum = 0;
          Random random = new Random();
          for(byte y = 0; y < numbers.Length; y++){
            numbers[y] = Convert.ToInt16(random.Next(1, 15));
            Console.WriteLine("El: {0}: {1}", y, numbers[y]);
            sum += numbers[y];
          }
          Console.WriteLine("Summ: {0}", sum);

          //Многомерные массивы
          // Запятая [,] указывает, что элементы массива будут массивами.
          // [2,3] означает, что в массиве будут два элемента тоже массивы с 3 элементами.
          char[,] symbols = new char[2,3];
          symbols[0, 0] = 'H';
          Console.WriteLine(symbols[0, 0]);

          // Мы можем присваивать значения в многомерном массиве таким способом.
          int[,] nums_2 = {
            {4, 6, 7},
            {5, 7, 3},
            {5, 2, 1}
          };
          nums_2[1,2] = 0;

         

          
      }


    }
        
}

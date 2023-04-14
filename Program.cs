using System;
using System.IO;

namespace csharp_learning{

    class Program{
        
        static void Main_add() {
          // System.Console.WriteLine("Введите текст: ");
          // string text = Console.ReadLine();
          // Использование изолированного кода. Как в Python with
          // using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)) {
          //   byte[] array_t = System.Text.Encoding.Default.GetBytes(text);
          //   stream.Write(array_t, 0, array_t.Length);
          // }

          using(FileStream stream1 = File.OpenRead("info.txt")){
            byte [] array = new byte[stream1.Length];
            stream1.Read(array, 0, array.Length);

            string textFromFile = System.Text.Encoding.Default.GetString(array);
            System.Console.WriteLine(textFromFile);
          }
       }
    }    
}

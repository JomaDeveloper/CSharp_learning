using System;

namespace csharp_learning{

    // Структуры очень похожи на классы, но используются для меньших объектов.

    struct Book{
        private string title, author, intro;

        public short pages;

        public void setValues(string title, string author){
            this.title = title;
            this.author = author;
        }

        public void printValues(){
            System.Console.WriteLine("{0} написал книгу '{1}'", this.author, this.title);
        }

    }

}
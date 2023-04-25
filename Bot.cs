using System;

namespace csharp_learning{

    class Bot: Class_learn, IRun {

        public Bot(){}

        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates) {
        }

    }

}
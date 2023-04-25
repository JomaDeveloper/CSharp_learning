namespace csharp_learning {

    // Интерфейсы просто описывают поля, методы и тд, но не не сам процесс.
    // Мы можем указать у класса эти интерфейсы и в нем появтся все, что необходио реализовать.
    // Например class Bot: Class_learn, IRun 
    interface IRun{
        float speed { get; set; }

        public void robotRun();

    }

}
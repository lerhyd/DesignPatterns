using System;

namespace SingletonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = FileWorkerSingleton.Instanse;
            var singleton2 = FileWorkerSingleton.Instanse;

            //var singleton = new FileWorkerSingleton();

            singleton1.WriteText("Hello, World!");
            singleton2.WriteText("Hi, Bro!");

            singleton1.Save();
            singleton2.Save();
        }
    }
}

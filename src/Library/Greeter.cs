using System;

namespace Library
{
    public class Greeter : Singleton<Greeter>
    {
        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

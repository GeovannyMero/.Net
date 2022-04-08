using System;

namespace AppSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingletonClass s1 = SingletonClass.GetInstance();
            SingletonClass s2 = SingletonClass.GetInstance();

            if(s1 == s2)
            {
                Console.WriteLine("Singleton works, bot variables contain the same instance");
            }else
            {
                Console.WriteLine("Sngleton failed");
            }
        }
    }
}

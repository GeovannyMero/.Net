using System;
using System.Threading;

namespace AppSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*SingletonClass s1 = SingletonClass.GetInstance();
            SingletonClass s2 = SingletonClass.GetInstance();

            if(s1 == s2)
            {
                Console.WriteLine("Singleton works, bot variables contain the same instance");
            }
            else
            {
                Console.WriteLine("Sngleton failed");
            }
            */

            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );


            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });
            
            process1.Start();
            process2.Start();
            
            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            SingletonHilos singleton = SingletonHilos.GetInstance(value);
            Console.WriteLine(singleton.Value);
        } 
    }
}

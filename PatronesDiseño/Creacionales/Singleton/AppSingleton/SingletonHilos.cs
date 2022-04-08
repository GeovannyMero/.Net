using System;
using System.Threading;

namespace AppSingleton
{
    class SingletonHilos
    {
        private SingletonHilos(){}

        private static SingletonHilos _instance;

        private static readonly object _lock = new object();

        public static SingletonHilos GetInstance(string value)
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonHilos();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
        public string Value { get; set; }
    }
}
using System;

namespace AppSingleton{
   public sealed class SingletonClass
   {
       private SingletonClass(){}

       private static SingletonClass _instance;

       public static SingletonClass GetInstance()
       {
           if(_instance == null)
            {
             _instance = new SingletonClass();   
            }
            return _instance;

       }
   } 
}
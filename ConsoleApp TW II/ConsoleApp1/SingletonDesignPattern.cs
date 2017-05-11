using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern

{
    class SingletonDesignPattern
    {
        public class SingleObject
        {
            private static SingleObject instance;

            private SingleObject()
            {

            }

            public static SingleObject Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new SingleObject();
                        Console.WriteLine("Object created");
                    }
                    else
                    {
                        Console.WriteLine("We already have the one, and only one object");
                    }
                    
                    return instance;
                }
            }

            
        }
    }
}

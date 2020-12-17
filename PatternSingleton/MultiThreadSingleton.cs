using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    /* Реализация одиночки в многопоточном исполнении
      */
    class MultiThreadSingleton
    {
        private MultiThreadSingleton() { }

        private static MultiThreadSingleton instance;

        private static readonly object locked = new object();

        public static MultiThreadSingleton GetInstance()
        {
            if(instance == null)
            {
                lock (locked)
                {
                    if(instance == null)
                    {
                        instance = new MultiThreadSingleton();
                        return instance;
                    }
                }
            }

            return instance;
        }
    }
}

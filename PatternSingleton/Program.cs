using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // пример использования одиночки
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if(singleton1 == singleton2)
            {
                Console.WriteLine("Переменные содержат один и тот же экземпляр");
            }
            else
            {
                Console.WriteLine("Переменные содержат разные экземпляры");
            }

            Console.ReadKey();
        }
    }
}

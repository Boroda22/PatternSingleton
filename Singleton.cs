﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    /* Класс Одиночка предоставляет метод `GetInstance`, который ведёт себя как
     * альтернативный конструктор и позволяет клиентам получать один и тот же
     * экземпляр класса при каждом вызове.*/
    class Singleton
    {
        // Конструктор Одиночки всегда должен быть скрытым, чтобы предотвратить
        // создание объекта через оператор new.
        private Singleton() { }

        /* Объект одиночки храниться в статичном поле класса.
         * Недостатком является неспособность правильно работать в многопоточной среде.*/
        private static Singleton _instance;

        /* Это статический метод, управляющий доступом к экземпляру одиночки.
         * При первом запуске, он создаёт экземпляр одиночки и помещает его в статическое поле.
         * При последующих запусках, он возвращает клиенту объект, хранящийся в статическом поле.*/
        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        /* Любой одиночка должен содержать некоторую бизнес-логику,
         * которая может быть выполнена на его экземпляре.*/
        public static void SomeBusinessLogic()
        {
            //......
        }
    }
}

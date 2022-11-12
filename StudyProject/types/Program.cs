using System;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление
            int integerVariable;
            // Инициализация
            integerVariable = 2;
            // Использование
            integerVariable *= 2; // тоже самое что и integerVariable = integerVariable * 2
            Console.WriteLine(integerVariable); // 4

        }

        static void Casting()
        {
            int integerVar = 2;
            // целое число приводится к вещественному
            double doubleVar = integerVar;
            // вещественное к целому нет
            // integerVar = doubleVar
            
            
        }


        static void ErrorExamples()
        {
            int myAge;
            // Ошибка. Пеерменная не инициализирована
            // Console.WriteLine(myAge);
        }
    }
}
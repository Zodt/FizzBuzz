using System;
using FizzBuzz.Helper;

namespace FizzBuzz.StructuralStyle
{
    public class FizzBuzzStructural
    {
        public void Start()
        {
            for (int i = 0; i < Settings.MaxNum; i++)
            {
                //Добавляемое условие
                if (i == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }

                //Постановка условий
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                //Проверка выполнения условий и вывод
                if (buzz & fizz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
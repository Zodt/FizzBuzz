using System;
using FizzBuzz.Helper;

namespace FizzBuzz.StructuralStyle
{
    public class FizzBuzzStructural
    {
        public void Start()
        {
            //ApproachNumber1();
            ApproachNumber2();
        }

        private static void ApproachNumber1()
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

        private static void ApproachNumber2()
        {
            for (int i = 0; i < Settings.MaxNum; i++)
                Console.WriteLine
                (
                    (i % 3, i % 5) switch
                    {
                        (0, 0) => "FizzBuzz",
                        (0, _) => "Fizz",
                        (_, 0) => "Buzz",
                        _ => i.ToString()
                    }
                );
        }
    }
}
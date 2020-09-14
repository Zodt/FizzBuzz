#nullable enable
using System;
using System.Linq;
using FizzBuzz.Helper;

namespace FizzBuzz.FunctionalStyle
{
    public class FizzBuzzFunctional
    {
        public void Start()
        {
            //Постановка основных условий и добавляемого условия
            Func<int, string, Func<int, string?>> conditions = (n, w) => num => num != 0 ? num % n == 0 ? w : null : null;
            
            //Связка условий с результатом
            Func<int, string?> fizz = conditions(3, "Fizz");
            Func<int, string?> buzz = conditions(5, "Buzz");

            // Особенности языка. Если вернуть конкатенацию 2х string? то они будут конвертированы в пустую строку
            Func<Func<int, string?>, Func<int, string?>, Func<int, string?>> fulfillingСonditions = 
            (func, func1) => num => (func(num), func1(num)) switch
                {
                    (null, null) => null, 
                    (var res, null) => res, (null, var res) => res, 
                    var (res, res1) => res + res1
                };
            
            //Проверка выполнения условий и вывод
            Enumerable
                .Range(0,Settings.MaxNum)
                .Select(i => Console.WriteLine(fulfillingСonditions(fizz, buzz)(i) ?? i.ToString()));
        }
    }
}


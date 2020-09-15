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
            Func<int, string, Func<int, string?>> conditions = (n, w) => num => num != default ? num % n == default ? w : null : null;
            
            //Связка условий с результатом
            Func<int, string?> fizz = conditions(3, "Fizz");
            Func<int, string?> buzz = conditions(5, "Buzz");

            // Особенности языка. Если вернуть конкатенацию 2х пустых "string?", то будет возвращена пустая строка
            Func<string, string?> checkResult = s => s?.Equals(string.Empty) ?? true ? null : s; 
            
            //Проверка выполнения условий и вывод
            Enumerable
                .Range(default,Settings.MaxNum)
                .Select(i => Console.WriteLine(checkResult(fizz(i) + buzz(i)) ?? i.ToString()));
        }
    }
}


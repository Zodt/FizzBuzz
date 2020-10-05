#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Helper;

namespace FizzBuzz.FunctionalStyle
{
    public class FizzBuzzFunctional
    {
        public void Start()
        {
            #region Условия

            Func<int, int, bool> zeroCondition = (index, number) => index != default;
            Func<int, int, bool> devCondition = (index, number) => index % number == default;
            Func<int, int, bool> sqrtCondition = (index, number) => Math.Sqrt(index) - (int)Math.Sqrt(index) == default;
            List<Func<int,int,bool>> conditions = new List<Func<int, int, bool>>{ zeroCondition, devCondition };

            #endregion

            #region Постановка основных условий и добавляемого условия

            Func<int, string, List<Func<int, int, bool>>, Func<int, string?>> executeConditions = 
                (number, word, conditionsList) => 
                    index => conditionsList.All(x=> x(index, number)) ? word : null;

            #endregion

            #region Связка условий с результатом

            // Связка условий с результатом
            Func<int, string?> fizz = executeConditions(3, "Fizz", conditions);
            Func<int, string?> buzz = executeConditions(5, "Buzz", conditions);
            Func<int, string?> sqrt = executeConditions(default, "Sqrt", new List<Func<int, int, bool>>{ zeroCondition, sqrtCondition });

            // Особенности языка. Если вернуть конкатенацию 2х пустых "string?", то будет возвращена пустая строка
            Func<string?, string?> checkResult = s => s?.Equals(string.Empty) ?? true ? null : s;

            // Результирующая функция 
            Func<int, string?> result = index => checkResult(fizz(index) + buzz(index) + sqrt(index));

            #endregion
            
            #region Выполнение условий и вывод

            Enumerable
                .Range(default, Settings.MaxNum)
                .Select(index => Console.WriteLine(result(index) ?? index.ToString()));

            #endregion
        }
    }
}


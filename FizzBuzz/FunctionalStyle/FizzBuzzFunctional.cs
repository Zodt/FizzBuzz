using System;
using System.Linq;
using FizzBuzz.Helper;

namespace FizzBuzz.FunctionalStyle
{
    public class FizzBuzzFunctional
    {
        public void Start()
        {
            #region Условия

            Func<int, int, bool> devCondition = (index, number) => index % number == default; // Основное условие
            Func<int, int, bool> zeroCondition = (index, number) => index != default; // Дополнительное условие
            //Func<int, int, bool> sqrtCondition = (index, number) => Math.Sqrt(index) % 1 == default; // Дополнительное условие
            //Func<int, int, bool> parityCondition = (index, number) => devCondition(index, 2); // Дополнительное условие

            Func<int, int, bool>[]? fizzBuzzConditions = { zeroCondition, devCondition }; // Основной список условий 
            //Func<int, int, bool>[]? sqrtConditions = { zeroCondition, sqrtCondition }; // Список дополнительных условий
            //Func<int, int, bool>[]? parityConditions = { zeroCondition, parityCondition }; // Список дополнительных условий

            #endregion

            #region Постановка основных условий и добавляемых условий

            Func<int, string, Func<int, int, bool>[]?, Func<int, string?>> linkDataWithCondition =
                (number, word, conditions) =>
                    index => conditions?.All(
                        x => x(index, number)) ?? false ? word : null;

            Func<int, string?>[]? conditionsWithData =
            {
                linkDataWithCondition(3, "Fizz", fizzBuzzConditions),
                linkDataWithCondition(5, "Buzz", fizzBuzzConditions), 
                //linkDataWithCondition(default, "Sqrt", sqrtConditions),
                //linkDataWithCondition(default, "Part", parityConditions),
            };

            #endregion

            #region Выполнение условий и вывод

            Func<int, string?> executeConditions = index => conditionsWithData
                .Select(x => x(index))
                .Aggregate(string.Concat)
                .NullIfEmpty();

            Enumerable
                .Range(default, Settings.MaxNum)
                .WriteLines(index => executeConditions(index) ?? index.ToString());

            #endregion
        }
    }
}
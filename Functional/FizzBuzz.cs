using System;
using System.Linq;
using FizzBuzz;
using FizzBuzzFunctional;

// ReSharper disable CommentTypo
// ReSharper disable ConvertToLocalFunction

#region Условия

Func<int, int, bool> devCondition = (index, number) => index % number == default;                               // Основное условие
Func<int, int, bool> zeroCondition = (index, _) => index != default;                                            // Дополнительное условие
Func<int, int, bool>[] fizzBuzzConditions = { zeroCondition, devCondition };                                    // Основной список условий 

// Добавление нового тега (демонстация быстрой возможности добавления нового тега)                              
Func<int, int, bool> sqrtCondition = (index, _) => Math.Abs(Math.Sqrt(index) % 1 - default(int)) < 0.00001F;    // Основное условие проверки числа на наличие корня
Func<int, int, bool>[] sqrtConditions = { zeroCondition, sqrtCondition };                                       // Список условий для проверки числа на наличие корня

// Добавление нового тега (демонстация быстрой возможности добавления нового тега)
Func<int, int, bool> parityCondition = (index, _) => devCondition(index, 2);                                    // Основное условие четности числа 
Func<int, int, bool>[] parityConditions = { zeroCondition, parityCondition };                                   // Список условий для проверки четности числа

#endregion

#region Постановка основных условий и добавляемых условий

Func<int, string, Func<int, int, bool>[]?, Func<int, string?>> linkDataWithCondition =
    (number, word, conditions) => index => conditions switch
    {
        { } conditionsList 
            when conditionsList.All(x => x(index, number)) => word,
        _ => null
    };

Func<int, string?>[] conditionsWithData =
{
    linkDataWithCondition(3, "Fizz", fizzBuzzConditions),
    linkDataWithCondition(5, "Buzz", fizzBuzzConditions),
    linkDataWithCondition(default, "Sqrt", sqrtConditions),                                                     // Добавление условий вывода дополнительных тегов
    linkDataWithCondition(default, "Part", parityConditions)                                                    // Добавление условий вывода дополнительных тегов
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

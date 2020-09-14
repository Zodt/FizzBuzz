using System;
using System.Collections.Generic;

namespace FizzBuzz.FunctionalStyle
{
    /// <summary>
    /// Класс расширений для FizzBuzzOOP
    /// </summary>
    internal static class FunctionalExtension
    {
        /// <summary>
        /// Перебор массива данных не возвращающий значения
        /// </summary>
        /// <param name="data">Массив данных</param>
        /// <param name="action">Обработчик данных</param>
        /// <typeparam name="T">Тип обрабатываемого массива данных</typeparam>
        public static void Select<T>(this IEnumerable<T> data, Action<T> action)
        {
            foreach (var value in data) 
                action(value);
        }
    }
}
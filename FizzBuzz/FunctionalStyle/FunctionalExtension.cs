#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace FizzBuzz.FunctionalStyle
{
    /// <summary>
    /// Класс расширений для FizzBuzzFunctional
    /// </summary>
    internal static class FunctionalExtension
    {
        public static void WriteLines<T, TU>(this IEnumerable<T> data, Func<T, TU> action)
        {
            Debug.Assert(data != null, nameof(data) + " != null");
            List<T>? values = data.ToList();
            foreach (var value in values)
            {
                Debug.Assert(value != null, nameof(value) + " != null");
                var invoke = action.Invoke(value);
                Console.WriteLine(invoke);
            }
        }

        
        public static string? NullIfEmpty(this string? s)
        {
            return s?.Equals(string.Empty) ?? true ? null : s!;
        }
            
            
        
    }
}
using System;
using System.Threading;

namespace FizzBuzz.OOP
{
    /// <summary>
    /// Контейнер наименования тега
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Наименование тега
        /// </summary>
        private readonly string _value;

        /// <summary>
        /// Проставление наименования тега
        /// </summary>
        /// <param name="value">Получаемое наименование тега</param>
        public Tag(string value)
        {
            _value = value;
        }

        public static Lazy<Tag> CreateInstance<T>(T num)
            => new Lazy<Tag>(() => new Tag($"{num}") , LazyThreadSafetyMode.None);
        
        public override string ToString() => _value;
    }
}
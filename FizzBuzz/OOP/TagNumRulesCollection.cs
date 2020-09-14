using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.OOP
{
    /// <summary>
    /// Коллекция контейнеров связки тегов с условиями
    /// </summary>
    public class TagNumRulesCollection
    {
        /// <summary>
        /// Коллекция контейнеров связки тегов с условиями
        /// </summary>
        private readonly List<TagNumRule> _tags;

        /// <summary>
        /// Проставление коллекции контейнеров связки тегов с условиями
        /// </summary>
        /// <param name="tags"></param>
        public TagNumRulesCollection(List<TagNumRule> tags)
        {
            _tags = tags;
        }

        /// <summary>
        /// Поиск контейнеров, условия которого выполнились 
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <param name="defaultValue">Значение по умолчанию, на случай ненахждения выполненных условий</param>
        /// <returns></returns>
        public TagNumRule Find(int num, TagNumRule defaultValue)
        {
            foreach (var tag in _tags.Where(tag => tag.IsSuccess(num)))
                return tag;
            return defaultValue;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.OOP
{
    /// <summary>
    /// Коллекция контейнеров связки тегов с условиями
    /// </summary>
    public class TagRulesCollection
    {
        /// <summary>
        /// Коллекция контейнеров связки тегов с условиями
        /// </summary>
        private readonly List<TagRule> _tags;

        /// <summary>
        /// Проставление коллекции контейнеров связки тегов с условиями
        /// </summary>
        /// <param name="tags">Коллекция контейнеров связки тегов с условиями</param>
        public TagRulesCollection(List<TagRule> tags)
        {
            _tags = tags;
        }

        /// <summary>
        /// Поиск контейнеров, условия которого выполнились 
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        public Tag Find(int num)
        {
            foreach (var tag in _tags.Where(tag => tag.IsSuccess(num)).ToList())
                return tag;
            return Tag.CreateInstance(num).Value;
        }
    }
}
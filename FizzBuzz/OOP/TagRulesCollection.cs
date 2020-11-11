using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.OOP
{
    /// <summary>
    ///     Коллекция контейнеров связки тегов с условиями
    /// </summary>
    public record TagRulesCollection(List<TagRule> Tags)
    {
        /// <summary>
        ///     Поиск контейнеров, условия которого выполнились
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        public Tag Find(int num)
        {
            foreach (var tag in Tags.Where(tag => tag.IsSuccess(num)).ToList())
                return tag;
            return Tag.CreateInstance(num);
        }
    }

}
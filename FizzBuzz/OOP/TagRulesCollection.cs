using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz.OOP
{
    /// <summary>
    ///     Коллекция контейнеров связки тегов с условиями
    /// </summary>
    public sealed record TagRulesCollection(List<TagRule> Tags)
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

        public override string ToString() => string.Concat
        (
            nameof(TagRulesCollection),
            @" { ",
                Tags
                    .Select(x => x.ToString())
                    .Aggregate((x, y) => $"{x}, {y}"),
            "}\n"
        );

    }

}
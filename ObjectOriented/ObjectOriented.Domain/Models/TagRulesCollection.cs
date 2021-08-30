using System.Collections.Generic;
using System.Linq;

namespace ObjectOriented.Domain.Models
{
    /// <summary>
    ///     Коллекция контейнеров связки тегов с условиями
    /// </summary>
    internal sealed record TagRulesCollection(List<TagRule> Tags)
    {
        /// <summary>
        ///     Поиск контейнеров, условия которого выполнились
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        public Tag Find(int num)
        {
            foreach (var tagRule in Tags.Where(tag => tag.IsSuccess(num)).ToList())
                return tagRule;
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
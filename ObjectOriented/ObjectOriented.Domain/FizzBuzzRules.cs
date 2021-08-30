using System.Collections.Generic;
using ObjectOriented.Domain.Conditions;
using ObjectOriented.Domain.Conditions.Interfaces;
using ObjectOriented.Domain.Models;

namespace ObjectOriented.Domain
{
    internal static class FizzBuzzRules
    {
        private static readonly List<ICondition> FizzConditions = new()
        {
            new DivCondition(3),
            new NotZeroCondition()
        };

        private static readonly List<ICondition> BuzzConditions = new()
        {
            new DivCondition(5),
            new NotZeroCondition()
        };

        private static readonly List<ICondition> FizzBuzzConditions = new()
        {
            new FizzBuzzStrategy(FizzConditions),
            new FizzBuzzStrategy(BuzzConditions)
        }; // Сделано так в качестве примера приемсвенности стратегий и условий

        /// <summary>
        ///     Связка условий с результатом
        /// </summary>
        internal static readonly TagRulesCollection RulesCollection = new
        (
            new List<TagRule>
            {
                new(GetTag(nameof(FizzBuzzConditions)), new FizzBuzzStrategy(FizzBuzzConditions)),
                new(GetTag(nameof(FizzConditions)), new FizzBuzzStrategy(FizzConditions)),
                new(GetTag(nameof(BuzzConditions)), new FizzBuzzStrategy(BuzzConditions))
            }
        );

        /// <summary>
        ///     Избавление от строковых значений в коде
        /// </summary>
        /// <param name="conditionsName">Наименование поля условий</param>
        /// <returns>Тег</returns>
        private static Tag GetTag(string conditionsName)
        {
            return Tag.CreateInstance(conditionsName.Replace("Conditions", ""));
        }
    }
}

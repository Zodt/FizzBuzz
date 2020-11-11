using System.Linq;
using FizzBuzz.OOP.Conditions;
using System.Collections.Generic;

namespace FizzBuzz.OOP
{
    public record FizzBuzzStrategy(List<ICondition> ConditionsOrStrategies) : ICondition
    {
        public bool IsConditionMet(int num)
        {
            return ConditionsOrStrategies
                .All(t => t.IsConditionMet(num));
        }
    }

}
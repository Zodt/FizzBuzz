using System.Collections.Generic;
using System.Linq;
using FizzBuzz.OOP.Conditions;

namespace FizzBuzz.OOP
{
    public class FizzBuzzStrategy : ICondition
    {
        private readonly List<ICondition> _conditionsOrStrategies;

        public FizzBuzzStrategy(List<ICondition> conditionsOrStrategies)
        {
            _conditionsOrStrategies = conditionsOrStrategies;
        }

        public bool IsConditionMet(int num)
        {
            return _conditionsOrStrategies.All(t => t.IsConditionMet(num));
        }
    }
}
﻿using System.Linq;
using FizzBuzz.OOP.Conditions;
using System.Collections.Generic;

namespace FizzBuzz.OOP
{
#nullable enable
    public sealed record FizzBuzzStrategy : ICondition
    {
        private IEnumerable<ICondition> ConditionsOrStrategies { get; }
        public FizzBuzzStrategy(IEnumerable<ICondition> conditionsOrStrategies) =>
            ConditionsOrStrategies = GetConditions(conditionsOrStrategies);

        private static IEnumerable<ICondition> GetConditions(IEnumerable<ICondition> conditionsOrStrategies)
        {
            List<ICondition> list = new();
            foreach (ICondition? condition in conditionsOrStrategies)
                if (condition is not FizzBuzzStrategy strategy) list.Add(condition);
                else list.AddRange(strategy.ConditionsOrStrategies);

            return list.Distinct();
        }

        public bool IsConditionMet(int num)
        {
            return ConditionsOrStrategies
                .All(t => t.IsConditionMet(num));
        }

        public override string ToString() => string.Concat
        (
            nameof(FizzBuzzStrategy),
            @" { ",
                ConditionsOrStrategies
                    .Select(x => x.ToString())
                    .Aggregate((x, y) => x?.ToString() + @", " + y?.ToString()),
            "}"
        );
    }
}
using System;
using System.Collections.Generic;
using FizzBuzz.Helper;
using FizzBuzz.OOP.Conditions;

namespace FizzBuzz.OOP
{
    // ReSharper disable once InconsistentNaming
    public class FizzBuzzOOP
    {
        #region Постановка основных условий и добавляемого условия

        private static readonly List<ICondition> FizzConditions = new ()
        {
            new DivCondition(3),
            new NotZeroCondition()
        };

        private static readonly List<ICondition> BuzzConditions = new ()
        {
            new DivCondition(5),
            new NotZeroCondition()
        };

        private static readonly List<ICondition> FizzBuzzConditions = new ()
        {
            new FizzBuzzStrategy(FizzConditions),
            new FizzBuzzStrategy(BuzzConditions)
        }; // Сделано так в качестве примера приемсвенности стратегий и условий

        #endregion
        
        /// <summary>
        ///     Связка условий с результатом
        /// </summary>
        private static readonly TagRulesCollection Collection = new 
        (
            new ()
            {
                new (GetTag(nameof(FizzBuzzConditions)), new (FizzBuzzConditions)),
                new (GetTag(nameof(FizzConditions)), new (FizzConditions)),
                new (GetTag(nameof(BuzzConditions)), new (BuzzConditions))
            }
        );

        /// <summary>
        ///     Точка входа и вывод результата
        /// </summary>
        public void Start()
        {
            Console.WriteLine(Collection);

            for (int i = default; i < Settings.MaxNum; i++) 
                Console.WriteLine(Collection.Find(i));
        }

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
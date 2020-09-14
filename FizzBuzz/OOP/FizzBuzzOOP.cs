using System.Collections.Generic;
using FizzBuzz.Helper;
using FizzBuzz.OOP.Conditions;

namespace FizzBuzz.OOP
{
    // ReSharper disable once InconsistentNaming
    public class FizzBuzzOOP
    {
        #region Постановка основных условий и добавляемого условия

        private static readonly List<ICondition> FizzConditions = new List<ICondition> {new DivCondition(3), new NotZeroCondition()};
        private static readonly List<ICondition> BuzzConditions = new List<ICondition> {new DivCondition(5), new NotZeroCondition()};
        private static readonly List<ICondition> FizzBuzzConditions = new List<ICondition> {new FizzBuzzStrategy(FizzConditions), new FizzBuzzStrategy(BuzzConditions)}; // Сделано так в качестве примера приемсвенности стратегий и условий

        #endregion
        
        /// <summary>
        /// Связка условий с результатом
        /// </summary>
        private static readonly TagNumRulesCollection Collection = new TagNumRulesCollection(new List<TagNumRule>
        {
            new TagNumRule(GetTag(nameof(FizzBuzzConditions)), new FizzBuzzStrategy(FizzBuzzConditions)),
            new TagNumRule(GetTag(nameof(FizzConditions)), new FizzBuzzStrategy(FizzConditions)),
            new TagNumRule(GetTag(nameof(BuzzConditions)), new FizzBuzzStrategy(BuzzConditions))
        });

        /// <summary>
        /// Точка входа и вывод результата 
        /// </summary>
        public void Start()
        {
            for (int i = 0; i < Settings.MaxNum; i++)
            {
                new Printer(Collection.Find(i, new TagNumRule(new Tag(i.ToString())))).Print();
            }
        }

        /// <summary>
        /// Избавление от строковых значений в коде
        /// </summary>
        /// <param name="conditionsName">Наименование поля условий</param>
        /// <returns>Тег</returns>
        private static Tag GetTag(string conditionsName)
        {
            return new Tag(conditionsName.Replace("Conditions",""));
        }
    }
}
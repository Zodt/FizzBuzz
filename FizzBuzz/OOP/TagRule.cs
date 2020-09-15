namespace FizzBuzz.OOP
{
    /// <summary>
    /// Контейнер связки условий с тегом
    /// </summary>
    public class TagRule
    {
        /// <summary>
        /// Условия
        /// </summary>
        private readonly FizzBuzzStrategy _strategy;
        /// <summary>
        /// Тег
        /// </summary>
        private readonly Tag _tag;

        /// <summary>
        /// Связка значения тега с условиями
        /// </summary>
        /// <param name="tag">Обрабатываемый тег</param>
        /// <param name="strategy">Условия</param>
        public TagRule(Tag tag, FizzBuzzStrategy strategy)
        {
            _strategy = strategy;
            _tag = tag;
        }

        /// <summary>
        /// Проверка выполнения условий
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <returns>Результат проверки</returns>
        public bool IsSuccess(int num)
        {
            return _strategy.IsConditionMet(num);
        }

        public static implicit operator Tag(TagRule x) => x._tag;
    }
}
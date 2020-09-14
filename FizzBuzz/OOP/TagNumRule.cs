namespace FizzBuzz.OOP
{
    /// <summary>
    /// Контейнер связки условий с тегом
    /// </summary>
    public class TagNumRule
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
        /// Проставление значения тега по умолчанию
        /// </summary>
        /// <param name="tag">Значения тега по умолчанию</param>
        public TagNumRule(Tag tag)
        {
            _tag = tag;
        }
        
        /// <summary>
        /// Связка значения тега с условиями
        /// </summary>
        /// <param name="tag">Обрабатываемый тег</param>
        /// <param name="strategy">Условия</param>
        public TagNumRule(Tag tag, FizzBuzzStrategy strategy)
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

        /// <summary>
        /// Получение тега
        /// </summary>
        /// <returns></returns>
        public Tag GetTag()
        {
            return _tag;
        }
    }
}
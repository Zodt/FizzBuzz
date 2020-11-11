namespace FizzBuzz.OOP
{
    /// <summary>
    ///     Контейнер связки условий с тегом
    /// </summary>
    public record TagRule(Tag Tag, FizzBuzzStrategy Strategy)
    {
        /// <summary>
        ///     Проверка выполнения условий
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <returns>Результат проверки</returns>
        public bool IsSuccess(int num)
        {
            return Strategy.IsConditionMet(num);
        }

        public static implicit operator Tag(TagRule x) => x.Tag;
    }

}
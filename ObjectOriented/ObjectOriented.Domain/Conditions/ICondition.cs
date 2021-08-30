namespace ObjectOriented.Domain.Conditions
{
    internal interface ICondition
    {
        /// <summary>
        ///     Проверка выполнения условий
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <returns>Результат проверки</returns>
        bool IsConditionMet(int num);
    }
}
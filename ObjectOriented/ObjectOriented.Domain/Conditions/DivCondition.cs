namespace ObjectOriented.Domain.Conditions
{
    /// <summary>
    ///     Условие делимости проверяемого числа по заданным условиям
    /// </summary>
    internal record DivCondition(int Divider) : ICondition
    {
        public bool IsConditionMet(int num)
        {
            return num % Divider == 0;
        }
    }

}
namespace ObjectOriented.Domain.Conditions
{
    /// <summary>
    ///     Условие несоответствия проверяемого числа значению по умолчанию
    /// </summary>
    internal record NotZeroCondition : ICondition
    {
        public bool IsConditionMet(int num)
        {
            return num != default;
        }
    }
}
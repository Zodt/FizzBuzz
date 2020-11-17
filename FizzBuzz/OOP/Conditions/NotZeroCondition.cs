namespace FizzBuzz.OOP.Conditions
{
    /// <summary>
    ///     Условие несоответствия проверяемого числа значению по умолчанию
    /// </summary>
    public record NotZeroCondition() : ICondition
    {
        public bool IsConditionMet(int num)
        {
            return num != default;
        }
    }
}
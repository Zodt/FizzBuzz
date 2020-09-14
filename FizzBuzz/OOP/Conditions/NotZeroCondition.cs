namespace FizzBuzz.OOP.Conditions
{
    /// <summary>
    /// Условие несоответствия проверяемого числа значению 
    /// </summary>
    public class NotZeroCondition : ICondition
    {
        public bool IsConditionMet(int num)
        {
            return num != default;
        }
    }
}
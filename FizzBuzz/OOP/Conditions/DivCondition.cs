namespace FizzBuzz.OOP.Conditions
{
    /// <summary>
    /// Условие делимости проверяемого числа по заданным условиям
    /// </summary>
    public class DivCondition : ICondition
    {
        /// <summary>
        /// Число из условий
        /// </summary>
        private readonly int _divider;

        /// <summary>
        /// Проставление числа из условий
        /// </summary>
        /// <param name="divider">Числа из условий</param>
        public DivCondition(int divider)
        {
            _divider = divider;
        }

        public bool IsConditionMet(int num)
        {
            return num % _divider == 0;
        }
    }
}
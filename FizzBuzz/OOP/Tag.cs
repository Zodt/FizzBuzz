namespace FizzBuzz.OOP
{
    /// <summary>
    ///     Контейнер наименования тега
    /// </summary>
    public sealed record Tag(string Value)
    {
        public static Tag CreateInstance(int num) => new($"{num}");
        public static Tag CreateInstance(string num) => new($"{num}");

        public override string ToString()
        {
            return Value;
        }
    }

}
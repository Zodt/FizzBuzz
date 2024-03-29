﻿namespace ObjectOriented.Domain.Models
{
    /// <summary>
    ///     Контейнер наименования тега
    /// </summary>
    public sealed record Tag(string Value)
    {
        public static Tag CreateInstance(int num) => new($"{num.ToString()}");
        public static Tag CreateInstance(string num) => new($"{num}");

        public override string ToString()
        {
            return Value;
        }
    }

}
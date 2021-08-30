using FizzBuzzSettings;
using ObjectOriented.Domain;

namespace ObjectOriented
{
    internal static class Program
    {
        private static void Main() => FizzBuzz
            .CreateInstance(Settings.MaxNum)
            .Print();
    }
}
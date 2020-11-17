using FizzBuzz.OOP;
using FizzBuzz.FunctionalStyle;
using FizzBuzz.StructuralStyle;

namespace FizzBuzz
{
    internal static class Program
    {
        private static void Main()
        {
            var fizzBuzzOop = new FizzBuzzOOP();
            var fizzBuzzFunctional = new FizzBuzzFunctional();
            var fizzBuzzStructural = new FizzBuzzStructural();

            fizzBuzzFunctional.Start();
        }
    }
}
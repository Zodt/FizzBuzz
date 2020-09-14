using System;

namespace FizzBuzz.OOP
{
    public class Printer
    {
        private readonly TagNumRule _context;

        public Printer(TagNumRule context)
        {
            _context = context;
        }

        public void Print()
        {
            Console.WriteLine(_context.GetTag());
        }
    }
}
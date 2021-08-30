using System;
using System.Collections.Generic;
using ObjectOriented.Domain.Models;

namespace ObjectOriented.Domain
{
    public class FizzBuzz
    {
        private readonly List<Tag> _tags;
        
        private FizzBuzz()
        {
            _tags = new List<Tag>();
        }

        public static FizzBuzz CreateInstance(int tagsCount)
        {
            var fizzBuzz = new FizzBuzz();
            for (var i = 0; i < tagsCount; i++)
            {
                fizzBuzz._tags.Add(FizzBuzzRules.RulesCollection.Find(i));
            }
            return fizzBuzz;
        }
        
        public void Print()
        {
            Console.WriteLine(FizzBuzzRules.RulesCollection);
            foreach (var tag in _tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}
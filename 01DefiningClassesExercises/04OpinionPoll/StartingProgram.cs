namespace _04OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartingProgram
    {
        public static void Main()
        {
            var listOfPeople = new List<Person>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split();
                var name = token.First();
                var age = int.Parse(token.Last());
                var person = new Person(name, age);
            
                listOfPeople.Add(person);
            }

            listOfPeople
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03OldestFamilyMember
{
    class StartingProgram
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var numberOfpeople = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < numberOfpeople; i++)
            {
                var nameAndAge = Console.ReadLine().Split();
                var name = nameAndAge.First();
                var age = int.Parse(nameAndAge.Last());

                var person = new Person();
                person.name = name;
                person.age = age;
                family.AddMember(person);
            }

            var oldestMan = family.GetOldestMember();

            Console.WriteLine($"{oldestMan.name} {oldestMan.age}");
        }
    }
}

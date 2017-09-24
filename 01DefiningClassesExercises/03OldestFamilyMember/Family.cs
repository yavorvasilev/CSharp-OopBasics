namespace _03OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Family
    {
        public List<Person> listOfPeople;

        public Family()
        {
            this.listOfPeople = new List<Person>();
        }

        public void AddMember(Person member)
        {
            listOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            var oldestMember = listOfPeople.OrderByDescending(p => p.age).First();
            return oldestMember;
        }
    }
}

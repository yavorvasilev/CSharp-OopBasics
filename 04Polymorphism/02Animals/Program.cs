using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Animals
{
    public class Program
    {
        public static void Main()
        {
            Animal dog = new Dog("Goshko", "Meso");
            Animal cat = new Cat("Ivan", "Java");

            Console.WriteLine(cat.ExplainMyself());
            Console.WriteLine(dog.ExplainMyself());

        }
    }
}

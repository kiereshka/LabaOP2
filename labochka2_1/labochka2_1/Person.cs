using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labochka2_1
{
    class Person
    {
        private int age { get; set; }
        public bool isPresent { get; private set; }

        public Person(int age, bool isPresent)
        {
            this.age = age;
            this.isPresent = isPresent;
        }

        public void showAge(Student a)
        {
            Console.WriteLine($"Возраст: {a.age}");
        }

        public void showPresent(Student a)
        {
            Console.WriteLine($"Присутствие: {a.isPresent}");
        }
    }
}

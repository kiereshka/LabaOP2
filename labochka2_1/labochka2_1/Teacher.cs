using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labochka2_1
{
    class Teacher : Person
    {
        public Teacher(int age, bool isPresent) : base(age, isPresent)
        { }
        public void checkHomework(Student a)
        {
            if (a.isPresent == true)
            {
                a.changeChecked();
            }
        }

        public void goingCheckHomework()
        {
            Console.Write("Иду проверять домашнее задание!\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labochka2_1
{
    class Student : Person
    {
        private int studYear { get; set; }
        private bool isChecked { get; set; }

        public Student(int studYear, bool isChecked, int age, bool isPresent) : base(age, isPresent)
        {
            this.studYear = studYear;
            this.isChecked = isChecked;
        }

        public void changeChecked()
        {
            isChecked = true;
        }

        public void studentYear()
        {
            Console.WriteLine(studYear);
        }

        public void showCheckedHomework(Student a)
        {
            if (a.isPresent == true)
            {
                if (isChecked == true)
                {
                    Console.WriteLine("Домашнее задание проверено! :)");
                }
                else
                {
                    Console.WriteLine("Домашнее задание не проверено! :(");
                }
            }
            else
            {
                Console.WriteLine("Какой ужас, кажется студент не пришел. Домашнее задание не может быть проверено.");
            }
        }
    }
}

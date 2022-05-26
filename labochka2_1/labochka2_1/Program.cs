using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labochka2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nСтуденты:");

            Student student1 = new Student(1, false, 18, true);
            Console.Write("\nНомер моего курса: ");
            student1.studentYear();
            student1.showAge(student1);
            student1.showPresent(student1);
            student1.showCheckedHomework(student1);

            Student student2 = new Student(2, false, 19, true);
            Console.Write("\nНомер моего курса: ");
            student2.studentYear();
            student2.showAge(student2);
            student2.showPresent(student2);
            student2.showCheckedHomework(student2);

            Student student3 = new Student(3, false, 21, false);
            Console.Write("\nНомер моего курса: ");
            student3.studentYear();
            student3.showAge(student3);
            student3.showPresent(student3);
            student3.showCheckedHomework(student3);

            Student student4 = new Student(4, false, 23, false);
            Console.Write("\nНомер моего курса: ");
            student4.studentYear();
            student4.showAge(student4);
            student4.showPresent(student4);
            student4.showCheckedHomework(student4);

            Console.WriteLine("\nУчитель:");
            Teacher teacher = new Teacher(43, true);

            Console.Write("Как-то скучно.. ");
            teacher.goingCheckHomework();

            teacher.checkHomework(student1);
            teacher.checkHomework(student2);
            teacher.checkHomework(student3);
            teacher.checkHomework(student4);

            Console.WriteLine("\nСтуденты:");

            Console.Write("\nНомер моего курса: ");
            student1.studentYear();
            student1.showAge(student1);
            student1.showPresent(student1);
            student1.showCheckedHomework(student1);

            Console.Write("\nНомер моего курса: ");
            student2.studentYear();
            student2.showAge(student2);
            student2.showPresent(student2);
            student2.showCheckedHomework(student2);

            Console.Write("\nНомер моего курса: ");
            student3.studentYear();
            student3.showAge(student3);
            student3.showPresent(student3);
            student3.showCheckedHomework(student3);

            Console.Write("\nНомер моего курса: ");
            student4.studentYear();
            student4.showAge(student4);
            student4.showPresent(student4);
            student4.showCheckedHomework(student4);
        }
    }
}

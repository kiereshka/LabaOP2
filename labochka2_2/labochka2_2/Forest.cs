using System;
using System.Collections.Generic;
using System.Text;

namespace labochka2_2
{
    public class Forest
    {
        public List<Tree> forestSize = new List<Tree>();

        public void noSort()
        {
            Console.WriteLine();
            foreach (Tree item in forestSize)
            {
                Console.WriteLine(item.type + " = " + item.age + " " + item.health + " " + item.pests + " ");
            }
        }
        public void sortType()
        {
            Console.WriteLine();
            forestSize.Sort(delegate (Tree a, Tree b)
            { return a.type.CompareTo(b.type); });

            foreach (Tree item in forestSize)
            {
                Console.WriteLine(item.type + "");
            }
            Console.WriteLine();
        }

        public void sortAge()
        {
            forestSize.Sort(delegate (Tree a, Tree b)
            { return a.age.CompareTo(b.age); });

            foreach (Tree item in forestSize)
            {
                Console.WriteLine(item.age + "");
            }
            Console.WriteLine();
        }

        public void sortHealth()
        {
            forestSize.Sort(delegate (Tree a, Tree b)
            {
                return a.health.CompareTo(b.health);
            });

            foreach (Tree item in forestSize)
            {
                Console.WriteLine(item.health + "");
            }
            Console.WriteLine();
        }
        public void sortPests()
        {
            forestSize.Sort(delegate (Tree a, Tree b)
            {
                return a.pests.CompareTo(b.pests);
            });

            foreach (Tree item in forestSize)
            {
                Console.WriteLine(item.pests + "");
            }
            Console.WriteLine();
        }
        public void deleteTree(Tree a)
        {
            Console.WriteLine($"Дерево {a.type} срублено!");
            forestSize.Remove(a);
        }

        public void addToForest(Tree a)
        {
            Console.WriteLine($"Дерево {a.type} посажено!");
            forestSize.Add(a);
        }

        public void showForestSize()
        {
            Console.WriteLine($"\nКоличество деревьев в лесу: {forestSize.Count}");
        }
    }
}

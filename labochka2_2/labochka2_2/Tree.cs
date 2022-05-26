using System;
using System.Collections.Generic;
using System.Text;

namespace labochka2_2
{
    public class Tree
    {
        public string type { get; set; }
        public int age { get; set; }
        public string health { get; set; }
        public bool pests { get; set; }

        public Tree(string type, int age, string health, bool pests)
        {
            this.type = type;
            this.age = age;
            this.health = health;
            this.pests = pests;
        }

        public void treeInfo(Tree a)
        {
            Console.WriteLine($"Состояние дерева: {a.type}, \nНаличие вредителей: {a.pests}");
        }
    }
}

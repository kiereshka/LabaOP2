using System;
using System.Collections.Generic;

namespace labochka2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree oak = new Tree("Oak", 35, "Perfect", false);
            Tree birch = new Tree("Birch", 54, "Good", false);
            Tree spruce = new Tree("Spruce", 74, "Normal", true);
            Tree acacia = new Tree("Acacia", 101, "Bad", true);

            Console.WriteLine("Состояние леса:");

            Forest forest = new Forest();
            forest.addToForest(oak);
            forest.addToForest(birch);
            forest.addToForest(spruce);
            forest.addToForest(acacia);

            forest.showForestSize();

            forest.noSort();

            Console.WriteLine("\nСортировка по типу, возрасту, состоянию и наличию вредителей:");
            forest.sortType();
            forest.sortAge();
            forest.sortHealth();
            forest.sortPests();

            forest.deleteTree(acacia);
            forest.showForestSize();
        }
    }
}

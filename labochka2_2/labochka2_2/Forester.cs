using System;
using System.Collections.Generic;
using System.Text;

namespace labochka2_2
{
    public class Forester
    {
        public void cutTree(Tree a, Forest forest)
        {
            forest.deleteTree(a);
        }

        public void addTree(Tree a, Forest forest)
        {
            forest.addToForest(a);
        }
    }
}

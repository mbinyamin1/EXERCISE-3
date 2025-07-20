using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    class GreedyUtils
    {
        //Greedy algorithm implementation for Assessed Exercise 3

        //Hints : 
        //Use lecture materials from Week 8
        // to aid with implementation...

        //You can take a list of items obtained from the user in the menu driven interface then convert it into
        // an array as you work your way towards a viable solution.

        //The delivered solution cannot exceed a weight limit of 100KG, make sure you are keeping track of this


        // - Adam.M 

        public static List<Item> GetGreedyManifesto(List<Item> items, double limit)
        {
            List<Item> selected = new List<Item>();

            items.Sort();
            items.Reverse();

            double currentWeight = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (currentWeight + items[i].Weight <= limit)
                {
                    selected.Add(items[i]);
                    currentWeight += items[i].Weight;
                }
            }

            return selected;
        }

    }
}

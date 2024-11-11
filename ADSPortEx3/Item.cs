using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    //Item class implementation for Assessed Exercise 3

    //For use as part of EX.3C

    //Use slides from Week 8A regarding the knapsack algorithm example to aid with implementation

    class Item : IComparable
    {
        public Item(string name, int value, int weight)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public double Weight
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public double ValRatio
        {
            get { throw new NotImplementedException(); }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

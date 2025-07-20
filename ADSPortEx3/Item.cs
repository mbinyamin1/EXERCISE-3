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
        private string thename;
        private int thevalue;
        private double theweight;
        public Item(string name, int value, double weight)
        {
            this.thename = name;
            this.thevalue = value;
            this.theweight = weight;
        }

        public string Name
        {
            get { return thename; }
            set { thename = value; }
        }
        
        public int Value
        {
            get { return thevalue; }
            set { thevalue = value; }
        }

        public double Weight
        {
            get { return theweight; }
            set { theweight = value; }
        }

        public double ValRatio
        {
            get { return Value / Weight; }
        }

        public int CompareTo(object obj)
        {
            Item other = obj as Item;
            return this.ValRatio.CompareTo(other.ValRatio);
        }
    }
}

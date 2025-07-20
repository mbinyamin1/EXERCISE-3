using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    class BigOFunctions
    {
        //Big O calculation for Assessed Exercise 3A

        //Hints : 
        //Use lecture materials from Week 6B to aid with calculations...

        //See ExampleQuestion() to see a suggested format for showing your
        // working out and final answer, both of which must be shown with correct
        // answers for full marks...


        public void ExampleQuestion()
        {
            //F.C
            Console.WriteLine("Enter a number 1:");          // 1
            int num1 = Int32.Parse(Console.ReadLine());      // 1

            Console.WriteLine("Enter a number 2:");          // 1
            int num2 = Int32.Parse(Console.ReadLine());      // 1

            for (int i = 1; i <= num2; i++)                  // n + 1
            {
                Console.WriteLine(num1.ToString() + " X "
                    + i.ToString() + " = " + (num1 * i));   // n
            }

            Console.WriteLine("End of program...");         // 1

            Console.ReadLine();                             // 1


            //Working out

            // 7 + 2n - All F.Cs added together
            // 2n     - Constants removed
            // n      - Coefficients removed
            // O(n)   - Final answer
        }

        public void QuestionOne()
        {
            Console.WriteLine("Inventory initialisation");       // 1

            Console.WriteLine("Define X dimension size: ");      // 1

            int x = Int32.Parse(Console.ReadLine());             // 1

            Console.WriteLine("Define Y dimension size: ");      // 1

            int y = Int32.Parse(Console.ReadLine());             // 1

             
            Item[,] inventory = new Item[x, y];                  // 1

            Console.WriteLine("Now loading inventory");          // 1

            for (int i = 0; i < x; i++)                          // n + 1
            {

                Console.WriteLine("Starting on row " + (i + 1)); // n

                for (int j = 0; j < y; j++)                      // n (n + 1)
                {
                    Console.WriteLine("Current Coords. " + i + " , " + j);  // n2

                    //TODO, load item from LoadItem() function here, finish this already Steve you **** - Dave

                    Item test = new Item((i + " , " + j), 1, 1); // n2

                    inventory[i, j] = test;                      // n2
                    Console.WriteLine("Added " + test.Name + " at Coords.");  //n2

                }
            }

            Console.WriteLine("Inventory finished loading.");    // 1
            Console.WriteLine("Happy travels!");                 // 1 

            Console.ReadLine();                                  // 1
        }

           //Working out

           // 11 + 3n + 5n(n) - All F.Cs added together
           // 3n + 5n(n)   - Constants removed
           // n + n2      - Coefficients removed
           // O(n2)   - Final answer
        public void QuestionTwo()
        {
            Console.WriteLine("How many items to analyse?: ");   // 1

            int n = Int32.Parse(Console.ReadLine());             // 1
             
            Item[] items = new Item[n];                          // n

            //TODO LoadItemManifesto(), yeah well I hardly see you pulling your finger out of your **** Dave - Steve

            for (int i = 0; i < (n - 1); i++)                    // n
            {
                Item current = items[i];                         // n - 1
                Console.WriteLine("Displaying value of: " + current.Name);  // n - 1
                Console.Write(current.Value);                    // n - 1

            }

            Console.WriteLine("Items analysed");                 // 1
             
            Console.ReadLine();                                  // 1
        }

           //Working out
  
           // 1 + 5n - All F.Cs added together
           // 5n     - Constants removed
           // n      - Coefficients removed
           // O(n)   - Final answer
    }
}

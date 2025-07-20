using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    internal class Program
    {
        static List<Item> itemList = new List<Item>();

        static void Main(string[] args)
        {


            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Demo sort..."
            // "2. Add item for greedy algorithm... ect
            //}

            //You won't need to create either of the utils classes, both use static methods.

            //I.e. 
            //SortUtils.InsertSort();
            //GreedyUtils.GetGreedyManifesto();

            while (true)
            {
                Console.WriteLine("\n--- THE MENU ---");
                Console.WriteLine("\n0. Exit Program");
                Console.WriteLine("\n1. Sort Integers");
                Console.WriteLine("2. Sort String");
                Console.WriteLine("3. Add Items for Manifest");
                Console.WriteLine("4. Display All Items.");
                Console.WriteLine("5. Greedy Algorithm.");

                Console.Write("\nEnter Your Choice: ");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    return;
                }
                else if (choice == "1")
                {
                    SortingIntegers();
                }
                else if (choice == "2")
                {
                    SortingStrings();
                }
                else if (choice == "3")
                {
                    AddItems();
                }
                else if (choice == "4")
                {
                    DisplayItems();
                }
                else if (choice == "5")
                {
                    GetGreedy();
                }
                else
                {
                    Console.WriteLine("\nInvalid Choice. Try again.");
                }
            }
        }

        static void SortingIntegers()
        {
            Console.WriteLine("\nEnter Integers Separated By Spaces:");
            string intInput = Console.ReadLine();

            if (!intInput.Contains(" "))
            {
                Console.WriteLine("Insert Space Please.");
                return;
            }

            string[] parts = intInput.Split(' ');
            int[] intArray = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                intArray[i] = Int32.Parse(parts[i]);
            }

            Console.WriteLine("\nPreviously Inserted Order:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine();

            SortUtils.InsertSortGen<int>(intArray);

            Console.WriteLine("New Sorted Integers:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSorting Complete.");
        }

        static void SortingStrings()
        {
            Console.WriteLine("\nEnter Strings Separated By Spaces:");
            string strInput = Console.ReadLine();

            if (!strInput.Contains(" "))
            {
                Console.WriteLine("\nInsert Space Please.");
                return;
            }

            string[] strArray = strInput.Split(' ');

            Console.WriteLine("\nPreviously Inserted Order:");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(strArray[i] + " ");
            }
            Console.WriteLine();

            SortUtils.InsertSortGen<string>(strArray);

            Console.WriteLine("New Sorted Strings:");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(strArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSorting Completed.");
        }

        static void AddItems()
        {
            Console.WriteLine("\n--- Add One Item ---");

            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Item Value (1–10): ");
            if (!int.TryParse(Console.ReadLine(), out int value) || value < 1 || value > 10)
            {
                Console.WriteLine("Invalid value. Must be between 1 and 10.");
                return;
            }

            Console.Write("Enter Weight: ");
            if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
            {
                Console.WriteLine("\nInvalid Weight.");
                return;
            }

            itemList.Add(new Item(name, value, weight));
            Console.WriteLine("\nItem Has Been Added Successfully.");
        }

        static void DisplayItems()
        {
            if (itemList.Count == 0)
            {
                Console.WriteLine("\nNo Items In Storage.");
                return;
            }

            Console.WriteLine("\nAll Items:");
            foreach (var item in itemList)
            {
                Console.WriteLine($"Name: {item.Name}, Value: {item.Value}, Weight: {item.Weight}, Ratio: {item.ValRatio:F2}");
            }
        }

        static void GetGreedy()
        {
            if (itemList.Count == 0)
            {
                Console.WriteLine("\nAdd Items First.");
                return;
            }

            Console.WriteLine("\nCalculating Payload...");
            var result = GreedyUtils.GetGreedyManifesto(itemList, 100);

            double totalWeight = 0;
            int totalValue = 0;

            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Name}, Value: {item.Value}, Weight: {item.Weight}, Ratio: {item.ValRatio:F2}");
                totalWeight += item.Weight;
                totalValue += item.Value;
            }
        }

    }
}

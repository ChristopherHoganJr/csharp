using System;

namespace DataStructures
{
    internal class DSLecture
    {
        static void Main(string[] args)
        {
            // ------- Arrays

            // Declare an array version 1
            string[] myGroceryArray = new string[2];

            myGroceryArray[0] = "Eggs";
            myGroceryArray[1] = "Bacon";

            Console.WriteLine(myGroceryArray[0]);
            Console.WriteLine(myGroceryArray[1]);

            // Console.WriteLine(myGroceryArray[2]);
            // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

            // Declare an array version 2
            string[] mySecondGroceryArray = { "Steak", "Chicken" };

            Console.WriteLine(mySecondGroceryArray[0]);
            Console.WriteLine(mySecondGroceryArray[1]);

            // Console.WriteLine(mySecondGroceryArray[2]);
            // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

            // ------- 2 Dimensional Arrays

            string[,] myTwoDimensionalArray = new string[,] { { "Yogurt", "Cheese" }, { "Cereal", "Milk" } };
            Console.WriteLine(myTwoDimensionalArray[0, 0]);
            Console.WriteLine(myTwoDimensionalArray[1, 0]);

            // ------- Lists

            // Declare a list version 1
            List<string> myGroceryList = new List<string>();
            myGroceryList.Add("Eggs");
            myGroceryList.Add("Bacon");

            Console.WriteLine(myGroceryList[0]);
            Console.WriteLine(myGroceryList[1]);


            // Declare a list version 2
            List<string> mySecondGroceryList = new List<string>() { "Steak", "Chicken" };

            // ------- IEnumerable

            IEnumerable<string> myGroceryEnumerable = myGroceryList;

            Console.WriteLine(myGroceryEnumerable.First());

            // ------- Dictionaries
            //          key, value
            Dictionary<string, string[]> myGroceryDictionary = new Dictionary<string, string[]>(){
                {"Beef", new string[]{"Steak", "Burger"}},
                {"Poultry", new string[]{"Chicken", "Turkey"}},
  
            };

            Console.WriteLine(myGroceryDictionary["Beef"][1]);

        }
    }
}
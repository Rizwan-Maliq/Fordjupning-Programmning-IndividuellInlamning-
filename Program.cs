using System;
using System.Collections.Generic;

public class Program
{
    // Method to filter elements in an array that start with the letter 'A'
    public static List<string> FilterElementsStartingWithA(string[] array)
    {
        List<string> resultList = new List<string>(); // Create a new list to store filtered elements

        // Iterate through each element in the array
        foreach (string element in array)
        {
            // Check if the element starts with 'a' or 'A'
            if (element.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                resultList.Add(element); // Add the element to the filtered list
            }
        }

        return resultList; // Return the filtered list
    }

    public static void Main()
    {
        // Array of strings
        string[] stringArray = { "Apple", "Banana", "Apricot", "Orange", "Annanas" };

        // Print the original array
        Console.WriteLine("Original Array:");
        foreach (var item in stringArray)
        {
            Console.WriteLine(item);
        }

        // Call the FilterElementsStartingWithA method to filter elements starting with 'a'
        List<string> filteredList = FilterElementsStartingWithA(stringArray);

        // Print the filtered list
        Console.WriteLine("\nFiltered List with elements starting with 'a':");
        foreach (var item in filteredList)
        {
            Console.WriteLine(item);
        }
    }
}

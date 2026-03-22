using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dataStore = new Dictionary<string, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Dictionary Manager ---");
            Console.WriteLine("a. Populate Dictionary");
            Console.WriteLine("b. Display Contents");
            Console.WriteLine("c. Remove a Key");
            Console.WriteLine("d. Add New Key/Value");
            Console.WriteLine("e. Append Value to Existing Key");
            Console.WriteLine("f. Sort Keys");
            Console.WriteLine("q. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine()?.ToLower();

            // Main menu dispatch based on user choice
            switch (choice)
            {
                case "a": // Populate dictionary with initial sample values
                    dataStore["A1"] = "Apple";
                    dataStore["B2"] = "Banana";
                    dataStore["C3"] = "Cherry";
                    Console.WriteLine("Dictionary populated with default values.");
                    break;

                case "b": // Display all dictionary entries to the console for review
                    Console.WriteLine("Current Contents:");
                    foreach (KeyValuePair<string, string> entry in dataStore)
                    {
                        Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                    }
                    break;

                case "c": // Remove an entry by key if it exists
                    Console.Write("Enter key to remove: ");
                    string keyToRemove = Console.ReadLine();
                    if (dataStore.Remove(keyToRemove))
                        Console.WriteLine("Key removed.");
                    else
                        Console.WriteLine("Key not found.");
                    break;

                case "d": // Add a new key/value pair (or overwrite existing key)
                    Console.Write("Enter new key: ");
                    string newKey = Console.ReadLine();
                    Console.Write("Enter value: ");
                    string newValue = Console.ReadLine();
                    dataStore[newKey] = newValue;
                    break;

                case "e": // Append text to the value of an existing key
                    Console.Write("Enter existing key: ");
                    string targetKey = Console.ReadLine();
                    if (dataStore.ContainsKey(targetKey))
                    {
                        Console.Write("Enter value to append: ");
                        string appendValue = Console.ReadLine();
                        dataStore[targetKey] += $", {appendValue}";
                        Console.WriteLine("Value appended.");
                    }
                    else
                        Console.WriteLine("Key not found.");
                    break;

                case "f": // Sort keys and display entries in sorted order
                    var sortedKeys = dataStore.Keys.ToList();
                    sortedKeys.Sort();
                    Console.WriteLine("Sorted Keys:");
                    foreach (var key in sortedKeys)
                    {
                        Console.WriteLine($"{key}: {dataStore[key]}");
                    }
                    break;

                case "q": // Quit the program loop
                    running = false;
                    break;

                default: // Handle unexpected menu input
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}
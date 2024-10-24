using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // File path to the data containing knapsack problem parameters
        string filename = "./data/ks_10000_0";

        // Read the dataset (values, weights) and the knapsack capacity from the file
        var (values, weights, capacity) = ReadDataFromFile(filename);

        // Run the knapsack algorithm to calculate maximum value, items selected, and execution time
        var (maxValue, itemsIncluded, timePassed) = Knapsack(values, weights, capacity);

        // Display the results
        Console.WriteLine("Capacity: " + capacity);
        Console.WriteLine("Maximum Value: " + maxValue);
        Console.WriteLine("Selected Items: " + string.Join(", ", itemsIncluded));
        Console.WriteLine("Execution Time: " + timePassed + " seconds");
    }

    // Function to read the knapsack problem data from a file
    static (List<int>, List<int>, int) ReadDataFromFile(string filename)
    {
        // Read all lines of the file
        var lines = File.ReadAllLines(filename);

        // Parse the capacity value (from the first line of the file)
        int capacity = int.Parse(lines[0].Split()[1]);

        // Create lists to store item values and weights
        var values = new List<int>();
        var weights = new List<int>();

        // Iterate over the remaining lines and extract values and weights
        foreach (var line in lines.Skip(1))
        {
            var parts = line.Split(); // Split each line into value and weight
            values.Add(int.Parse(parts[0])); // Add the value to the list
            weights.Add(int.Parse(parts[1])); // Add the weight to the list
        }

        // Return the parsed data: values, weights, and capacity
        return (values, weights, capacity);
    }

    // Function to solve the knapsack problem using dynamic programming
    static (int, List<int>, double) Knapsack(List<int> values, List<int> weights, int capacity)
    {
        // Start the stopwatch to measure execution time
        var stopwatch = Stopwatch.StartNew();

        // Number of items
        int n = values.Count;

        // Arrays for dynamic programming (previous and current DP table)
        int[] prevDp = new int[capacity + 1];
        int[] currDp = new int[capacity + 1];

        // Loop over all items
        for (int i = 1; i <= n; i++)
        {
            // Loop over all capacities from the current capacity to 0 (backwards)
            for (int w = capacity; w >= 0; w--)
            {
                // If the item can fit in the knapsack (weight is less than or equal to current capacity)
                if (weights[i - 1] <= w)
                {
                    // Update the current DP value to the maximum of either:
                    // 1. Not taking the item (prevDp[w])
                    // 2. Taking the item (value of the item + value without the item's weight)
                    currDp[w] = Math.Max(prevDp[w], prevDp[w - weights[i - 1]] + values[i - 1]);
                }
                else
                {
                    // If the item cannot fit, carry forward the previous value
                    currDp[w] = prevDp[w];
                }
            }
            // Copy current DP table to previous for the next iteration
            Array.Copy(currDp, prevDp, capacity + 1);
        }
        // The maximum value that can be obtained with the given capacity
        int maxValue = prevDp[capacity];
        // Initialize remaining capacity to trace back the items selected
        int remainingCapacity = capacity;
        var itemsIncluded = new List<int>(new int[n]);

        // Trace back the items selected using the DP table
        for (int i = n; i > 0; i--)
        {
            // Check if the item was included by comparing the DP values
            if (remainingCapacity >= weights[i - 1] && prevDp[remainingCapacity] == prevDp[remainingCapacity - weights[i - 1]] + values[i - 1])
            {
                // Mark the item as selected
                itemsIncluded[i - 1] = 1;
                // Decrease the remaining capacity
                remainingCapacity -= weights[i - 1];
            }
        }
        // Stop the stopwatch and get the elapsed time
        stopwatch.Stop();
        double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
        // Return the maximum value, the list of items included, and the execution time
        return (maxValue, itemsIncluded, elapsedSeconds);
    }
}
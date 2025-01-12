using System;


public class Program
{
    static void main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Instantiate a new List as a working copy of the main List
        List<int> result = new List<int>(data.Count);

        //Slice the data set so we store values that will be first 
        List<int> copy = data.GetRange(data.Count - amount, amount);

        // Store the rest of the data set
        List<int> copy2 = data.GetRange(0, data.Count - amount);

        //Validate the amount to move is greater than zero
        if (amount != 0)
        {
            // Copy the first data set into the working List    
            for (int i = 0; i < copy.Count; i += 1)
            {
                result.Insert(i, copy[i]);
            }
            // Copy the second data set after we have insert the first data set
            for (int i = 0; i < copy2.Count; i += 1)
            {
                result.Insert(amount + i, copy2[i]);
            }
        }
        else
        {
            // IF the amount is Zero then make a copy
            result = data;
        }
        //Set the data param to be the same as the working list
        data = result;

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}
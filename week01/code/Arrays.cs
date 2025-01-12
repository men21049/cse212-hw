public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1:
        // Instantiate the variable to hold the results
        double[] multiples = new double[length];

        //loop trough the total number of multiples
        for (int n = 1; n <= length; n += 1)
        {
            //append the multiple into the multiples variable
            multiples[n - 1] = number * n;
        }
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Slice the data set so we store values that will be first 
        List<int> copy = data.GetRange(data.Count - amount, amount);

        // Store the rest of the data set
        List<int> copy2 = data.GetRange(0, data.Count - amount);

        // Copy the first data set into the working List    
        for (int i = 0; i < copy.Count; i += 1)
        {
            data.Insert(i, copy[i]);
        }
        // Copy the second data set after we have insert the first data set
        for (int i = 0; i < copy2.Count; i += 1)
        {
            data.Insert(amount + i, copy2[i]);
        }
    }
}

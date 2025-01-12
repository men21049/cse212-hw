public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int idxL1 = 0;
        int idxL2 = 0;
        var res = new int[select.Length];

        for (var index = 0; index < select.Length; ++index)
        {
            if (select[index] == 1)
            {
                res[index] = list1[idxL1];
                idxL1 += 1;
            }
            else
            {
                res[index] = list2[idxL2];
                idxL2 += 1;
            }
        }
        return res;
    }
}
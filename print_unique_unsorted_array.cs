static void PrintSortedArray(int[] arr)
{
    HashSet<int> set = new HashSet<int>(arr);
    foreach (var item in set)
    {
        Console.Write(item + " ");
    }
}

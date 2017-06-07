static void PrintSortedArray(int[] arr)
{
    for (int i = 0; i < arr.Length;)
    {
        Console.Write(arr[i] + " ");
        int j = i + 1;
        while (j< arr.Length && arr[j] == arr[i])
        {
            j++;
        }
        i = j;
    }
}

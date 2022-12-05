int[] arr = { 8, 12, 6, 2, 18 };
bubbleSort(arr);
printAll(arr);

// Function
void printAll(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + "\t");
}

void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void bubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                swap(ref arr[j], ref arr[j + 1]);
            }
        }
    }
}
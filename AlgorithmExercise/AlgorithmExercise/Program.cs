int[] arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17 };
heapSort(arr);
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

void insertionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j > 0; j--)
        {
            if (arr[j] < arr[j - 1])
                swap(ref arr[j], ref arr[j - 1]);
        }
    }
}

void heapify(int[] arr, int n, int i)
{
    int largest = i;
    int l = 2 * i + 1;
    int r = 2 * i + 2;
    if (l < n && arr[largest] < arr[l])
        largest = l;
    if (r < n && arr[largest] < arr[r])
        largest = r;
    if (i != largest)
    {
        swap(ref arr[largest], ref arr[i]);
        heapify(arr, n, largest);
    }
}

void heapSort(int[] arr)
{
    for (int i = arr.Length / 2; i >= 0; i--)
    {
        heapify(arr, arr.Length,i);
    }
    for (int i = arr.Length - 1; i > 0; i--)
    {
        swap (ref arr[i], ref arr[0]);
        heapify(arr, i, 0);
    }
}

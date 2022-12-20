int []arr = new int [11];
init(arr);
mergeSort(arr, 0, arr.Length - 1);
printAll(arr);

// Function
void init(int []arr)
{
    Random random = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 100);
    }
}

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

void quickSort(int[] arr, int low, int high)
{
    if (low >= high)
    return;
    int pivot = arr[high];
    int j = low - 1;
    for (int i = low; i < high; i++)
    {
        if (pivot > arr[i])
        {
            swap (ref arr[i], ref arr[++j]);
        }
    }
    swap (ref arr[j + 1], ref arr[high]);
    quickSort(arr, low, j);
    quickSort(arr, j + 2, high);
}

void mergeSort(int []arr, int low, int high)
{
    if (low >= high)
        return;
    int mid = (low + high) / 2;
    mergeSort(arr, low, mid);
    mergeSort(arr, mid + 1, high);
    merge (arr, low, mid, high);
}

void merge(int []arr, int low, int mid, int high)
{
    int arr1 = mid - low + 1;
    int arr2 = high - mid;
    int []leftArray = new int [arr1];
    int []rightArray = new int [arr2];
    int i, j;
    for (i = 0; i < arr1; i++)
    {
        leftArray[i] = arr[low + i];
    }
    for (j = 0; j < arr2; j++)
        rightArray[j] = arr[mid + j + 1];
    i = j = 0;
    int k  = low;
    while (i < arr1 && j < arr2)
        {
            if (leftArray[i] < rightArray[j])
            {
                swap(ref arr[k++], ref leftArray[i++]);
            }
            else
            {
                swap(ref arr[k++], ref rightArray[j++]);
            }
        }
    while (i < arr1)
    {
        arr[k++] = leftArray[i++];
    }
    while (j < arr2)
        arr[k++] = rightArray[j++];
}
 
int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

int n = arr.Length;

for (int i = 0; i<n-1; i++)
{
    int min=i;
    for (int j=i+1; j<n; j++)
    {
        if (arr[j] < arr[min])
        {
            min = j;
        }
    }
    // Swap the found minimum element with the first element
    int temp = arr[i];
    arr[i] = arr[min];
    arr[min] = temp;
}
foreach (int num in arr)
{
    Console.Write(num + " ");
}
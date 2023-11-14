// сортировка массива выбором максимального/минимального

using System.Globalization;

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void  PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
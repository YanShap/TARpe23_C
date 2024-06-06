namespace Homework_14_3

class SortingComparison
{
    static void Main()
    {
        Random rand = new Random();

        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 1001);
        }

        Console.WriteLine("Original array:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("Sorted array using Insertion Sort:");
        PrintArray(array);

        int[] array5000 = GenerateRandomArray(5000, 0, 5000);
        int[] array50000 = GenerateRandomArray(50000, 0, 5000);
        int[] array500000 = GenerateRandomArray(500000, 0, 5000);

        Console.WriteLine("\nInsertion Sort Times:");
        MeasureSortingTime(array5000, InsertionSort, "Array of 5000 elements");
        MeasureSortingTime(array50000, InsertionSort, "Array of 50000 elements");
        MeasureSortingTime(array500000, InsertionSort, "Array of 500000 elements");

        Console.WriteLine("\nBubble Sort Times:");
        MeasureSortingTime(array5000, BubbleSort, "Array of 5000 elements");
        MeasureSortingTime(array50000, BubbleSort, "Array of 50000 elements");
        MeasureSortingTime(array500000, BubbleSort, "Array of 500000 elements");
    }

    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];

            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random rand = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(minValue, maxValue + 1);
        }
        return array;
    }

    static void MeasureSortingTime(int[] array, Action<int[]> sortMethod, string description)
    {
        int[] arrayCopy = (int[])array.Clone();

        var watch = System.Diagnostics.Stopwatch.StartNew();
        sortMethod(arrayCopy);
        watch.Stop();

        Console.WriteLine($"{description}: {watch.ElapsedMilliseconds} ms");
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
// Буткемп.Урок 4. Алгоритм "Сортировка выбором"
// Урок 13. Сортировка подсчётом
// В буткемп_06 все виды сортировки от камянецкого

int[] array = { -10, -5, -8, -30, 2, 3, 4, 1, 5, 9, 1, 1, 5, 0, 4, 7, 0, 5, 6, 1, 4, 7, 5 };
int[] sortedArray = CountingSortExtented(array);

// CountingSort(array);


Console.WriteLine(string.Join(", ", sortedArray));

// Console.WriteLine(string.Join(", ", array));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10];     // массив повторений
    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
        // int ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}

int[] CountingSortExtented(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + offset + 1];


    Console.WriteLine(max + offset + 1);


    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i - offset;
            index++;
        }
    }
    return sortedArray;
}

//Буткемп. Программирование
// Урок 2. Алгоритмы в C# . Эффективность алгоритма

//Дано число N. Нужно показать числа от -N до N.

// int n = 123;
// for (int i = -n; i <= n; i++)
// {
//     Console.WriteLine(i);
// }
// Сделали как выше, но нужно делать через МЕТОД

// int GetValueByUser(string text)
// {
//     Console.WriteLine(text);
//     return int.Parse(Console.ReadLine());
// }


// void PrintNumbers1(int n)
// {
//     for (int i = -n; i <= n; i++)
//     {
//         Console.Write(i + " ");       //нельзя внутри метода использовать Console.Write
//     }
// }

// int n = GetValueByUser("Введите N");
// PrintNumbers1(n);

//Перепишем:
// int GetValueByUser(string text)
// {
//     Console.WriteLine(text);
//     return int.Parse(Console.ReadLine());
// }
// int n = GetValueByUser("Введите N");
// string PrintNumbers2(int n)
// {
//     string output = String.Empty;

//     for (int i = -n; i <= n; i++)
//     {
//         //output = output + (i + " "); 
//         output = output + $"{i} ";
//     }
//     return output;
// }
// int n = GetValueByUser("Введите N");
// Console.WriteLine(PrintNumbers2(n)); //       теперь Console.Write вне метода
// File.WriteAllText("data.txt", PrintNumbers2(n));   //чтобы печаталось в файл. Появился файлик текст справа блокнот


// string PrintNumbers3(int n)
// {
//     string output = "0";

//     for (int i = 1; i <= n; i++)        //тут начали от нуля, тогда запись меняется в теле, но встречается два раза ноль:
//     {
//         output = $"{-i} " + output + $" {i}";
//     }
//     return output;
// }
// Console.WriteLine(PrintNumbers3(n));


//следующая задача - дан массив чисел, надо найти сумму пяти чисел.
// всего - array -n =50
//подмассив =m=3    1 2 3 4 5 6 7 8 9 (здесь 7 массивов троек, считается n - m + 1

// int[] GetRangeSum1(int[] array, int m)
// {
//     int n = array.Length;
//     int[] t = new int[n - m + 1];

//     int index = 0;
//     for (int i = 0; i <= n - m; i++)
//     {
//         for (int j = i; j < i + m; j++)
//         {
//             t[index] += array[j];
//         }
//         index++;

//     }
//     return t;
// }


int[] GetRangeSum2(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n - m + 1];
    int sum = 0;
    for (int i = 0; i < m; i++) sum += array[i];
    int index = 0;

    t[index++] = sum;
    for (int i = 1; i <= n - m; i++)
    {
        sum = sum - array[i - 1] + array[i + m - 1];
        t[index++] = sum;
    }
    return t;

}

int[] CreateArray(int size) => new int[size]; //количество элементов в массиве

string Print(int[] array) => $"[{String.Join(", ", array)}]";

void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray();

int[] numbers = CreateArray(5);
Fill(ref numbers);
Console.WriteLine(Print(numbers));
int count = 2;              //сколько элементов массива сложить
int[] sumGroupNumbers = GetRangeSum2(numbers, count);
Console.WriteLine(Print(sumGroupNumbers));
Console.WriteLine("+");

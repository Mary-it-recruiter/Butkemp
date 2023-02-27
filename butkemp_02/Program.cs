﻿// Буткемп. Урок 3 Big O Natation
//Разница массивов  и списков. В список можно положить разные типы данных: строку, число, символ и т.д., а в массиве хранятся данные только одного типа, поэтому списки работают медленнее.


//  Big O – определяет верхнюю границу для работы алгоритма (свободная верхняя граница). Функция описывает зависимость между входными параметрами и количеством операций которые придется выполнить. Big O показывает как будет меняться производительность алгоритмов в зависимости от роста входящих данных. Если будем увеличивать количество входящих данных, то будут расти две вещи: время за которое отрабатывается наш алгоритм и количество памяти, используемое данным алгоритмом. Скорость роста этих параметров и показывает нам Big O.
// Big O нотация нужна для описания сложности алгоритмов. Тут важно понимать, что мы оцениваем время выполнения лишь косвенно, потому что на разном окружение один и тот же код может выполняться разное время. Понимание этой нотации нужно чтобы научиться видеть и исправлять не оптимальный код.
// При больших объемах данных **очень важна сложность алгоритмов.  
//https://www.youtube.com/watch?v=Fu4BzQNN0Qs

//О(1)  - константная сложность: (функция работает за константное время вне зависимости от количества данных, которые к нам поступают)Хоть массив из 10_000, хоть из 3 элементов, ожинаково по времени будет.
// function getLastElement(arr)
// {
//     return arr[arr.Length - 1];   //Функция, которая принимает массив данных и возвращает последний элемиент массива
// }

//___________________________________________________________________________________________________________________________________________________



//О(n) -линейная сложность, так как линейная зависимость времени от количества данных на входе.
// function getSumOfArrray(arr)
// {
//     let sum = 0;
//     for (int i = 0; i < length; i++)
//     {
//         sum += arr[i];                   //Функция, которая считает сумму всех элементов массива, которые передаются ей на вход и возвращает число
//     }
//     return sum;
// }

//___________________________________________________________________________________________________________________________________________________

//О(log n) - логарифмическая сложность
//C:\Users\mivanova\Desktop\Гикбрейнс Иванова М\Csharp projects\Butkemp\butkemp_02\O(log n).jpg
// Здесь на каждой итерации берем наш массив входных данных и делим этот массив на две части, одну из них откидываем.
// На каждой итерации уменьшаем объем данных необходимых для обработки вдвое
//___________________________________________________________________________________________________________________________________________________

//О(n log n) 
//О(n^2) - квадратичная сложность  C:\Users\mivanova\Desktop\Гикбрейнс Иванова М\Csharp projects\Butkemp\butkemp_02\O(n2).jpg
//О(n^3) - кубическая сложность(если три вложенных цикла)
//О(2^n) - экспоненциальная сложность( C:\Users\mivanova\Desktop\Гикбрейнс Иванова М\Csharp projects\Butkemp\butkemp_02\O(n2).jpg)

//Примеры:
// О(n+n^2)   отбрасываем несущественную часть в сложности , получается О(n^2)
// О(n+log n)  ====>   О(n), так как логорифмическая растет несущественно
//O(60*2^n+10*n^100), можно отбросить все константы O(2^n+n^100) ====>  O (n^100)
// О(n^2+m)  ====>  О(n^2+m)  не можем откинуть m, так как про m число ничего не знаем
// Резюмируем, в Big O откидываются все несущественные сложности и константы, так как они при n-->к бесконечности будут расти в разы медленнее основной нашей сложности алгоритма, поэтому ими мы пренебрегаем.


//___________________________________________________________________________________________________________________________________________________
//По лекции:


// int[] array = new int[5];
// for (int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(string.Join(" ", array));
//Сложность алгоритма О(1) 

//___________________________________________________________________________________________________________________________________________________

// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j);
//         Console.Write("\t");
//     }
//     Console.WriteLine();
// }
//Сложность алгоритма О(n^2) 
//___________________________________________________________________________________________________________________________________________________

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {

        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);

    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
//Сложность алгоритма О(n^2/2) 
//___________________________________________________________________________________________________________________________________________________
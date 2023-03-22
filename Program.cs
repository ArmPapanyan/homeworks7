// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// Console.WriteLine("Input m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[m, n];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }
// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < m; i++)
//     {
//         Console.Write("");
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("");
//         Console.WriteLine();
//     }
// }


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4


// Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input m");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [n,m];
// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("not foound element");
// }
// else
// {
//     Console.WriteLine($"element value {n} rows and {m}  colums {numbers[n-1,m-1]}");
// }

// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write(" ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("");
//         Console.WriteLine(""); 
//     }
// }


//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:


Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void array(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,9);
Console.Write($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}

void arithmetic (int m, int n)
{
Console.Write("arithmetic mean rows ");
int i,j;
Random rand = new Random();
for (j = 0; j < n; j++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + randomArray[i,j];
}
Console.Write($"{sum/(i):F1}; ");
}
}
array(m,n);
arithmetic(m,n);
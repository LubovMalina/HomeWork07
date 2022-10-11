/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();
Console.WriteLine("Введите  количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array1 = FillArrayDoubleNumbers(m,n);
PrintDoubleArray(array1);

double [,] FillArrayDoubleNumbers (int rows, int columns)                         // Инициализация массива с вещественными числами
{
    double[,] filledArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = Convert.ToDouble(new Random().Next(-1,10) / 10.0);
        }
    }
    return filledArray;
}

void PrintDoubleArray (double [,] inputArray)                                     // Вывод массива c вещественными числамина экран
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i,j]);
        }
        Console.WriteLine();
    }
}
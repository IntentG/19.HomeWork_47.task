/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Создаём массив. \nВведите колличество строк:");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Создаём массив. \nВведите колличество столбцов:");
int columns = int.Parse(Console.ReadLine());

/// Рандомный двумерный массив
double [,] GetArray(int rows, int columns)
{
    double [,] array = new double[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.NextDouble() * (10 + 10) - 10;
                }
            }
    return array;
}

/// Метод печати массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,8}", Math.Round(array[i, j], 1));
        }
        Console.WriteLine();
    }
}

double [,] array = GetArray(rows, columns);
Console.WriteLine("Массив случайных вещественных чисел: \n");
PrintArray(array);
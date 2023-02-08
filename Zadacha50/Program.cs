// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[m, n];
Console.WriteLine("Введите номер строки: ");
int rowuser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int columuser = Convert.ToInt32(Console.ReadLine());

FillMatrix(matr);
FindElementMatrix(matr, rowuser, columuser);


void FillMatrix(int[,] matrixFill)

{
    for (int i = 0; i < matrixFill.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFill.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElementMatrix(int[,] findElem, int row, int colums)
{
    if (rowuser > findElem.GetLength(0) || columuser > findElem.GetLength(1))

        {
             Console.WriteLine("такого элемента нет");
        }
    else
        {
            Console.WriteLine($"значение элемента {rowuser} строки и {columuser} столбца равно {findElem[rowuser - 1, columuser - 1]}");
        }

}










// №52 Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[rows, columns];

void CreatFillArray()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void AverageColumns()
{
    double sum = 0;
    for (int j = 0; j < newArray.GetLength(1); j++)
    {

        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            sum = sum + newArray[i, j];
        }
        Console.Write(sum/rows + " | ");
    }

    Console.WriteLine();

}

CreatFillArray();
PrintArray();
AverageColumns();

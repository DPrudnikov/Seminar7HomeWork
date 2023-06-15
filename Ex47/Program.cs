// Ex47 Задайте двумерный массив размером m x n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] newArray = new double [rows,columns];

void CreatFillArray ()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
           newArray[i,j] =  new Random().NextDouble();
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(Math.Round(newArray[i,j],2) + " | "); 
        }
        Console.WriteLine();
    }
}


CreatFillArray ();
PrintArray();


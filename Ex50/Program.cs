// Зад. 50 Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.WriteLine("Задайте искомую строку ");
int findrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте искоый столбец ");
int findcolumns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[6, 5];

void CreatFillArray()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 100);
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

void FindElementPosition()
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if ((i == findrows) && (j == findcolumns))
            {
                Console.Write(newArray[findrows, findcolumns]);
            }

        }

    }
    Console.WriteLine();

    if ((findrows > newArray.GetLength(0)) || (findcolumns > newArray.GetLength(1)))
        {
            Console.Write($"Элемента с заданной позицией{(findrows, findcolumns)} в массиве нет");
        }

    

}

CreatFillArray();
PrintArray();
Console.WriteLine("________________");
FindElementPosition();


/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/
using static System.Console;
Clear();
WriteLine("Введите размер матрицы через пробел: ");

int [] parameters = GetArrayForString(ReadLine()!);
int [,] matrix=GetMatrixArray(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);
WriteLine();

WriteLine("Введите позиции элемента в массиве через пробел: ");
int [] position = GetArrayForString(ReadLine()!);
if (position[0]>matrix.GetLength(0) || position[0]< 0 || position[1]>matrix.GetLength(1)|| position[1]<0)
{
    WriteLine("Такого элемента в массиве нет");
    return;
}
WriteLine($"Необходимый элемент равен: {matrix[position[0],position[1]]}");

int[,] GetMatrixArray(int rows,int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i=0; i<resultMatrix.GetLength(0);i++)
    {
        for (int j=0; j<resultMatrix.GetLength(1);j++)
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    }
}

int[] GetArrayForString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parametersNum = new int[parames.Length];
    for (int i = 0; i < parametersNum.Length ; i++)
    {
        parametersNum[i]=int.Parse(parames[i]);
    }
    return parametersNum;
}
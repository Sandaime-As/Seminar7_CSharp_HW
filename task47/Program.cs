/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using static System.Console;
Clear();
WriteLine("Введите размер матрицы, max и min значение через пробел: ");
int [] parameters = GetArrayForString(ReadLine()!);
double [,] matrix=GetMatrixArray(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);

double[,] GetMatrixArray(int rows,int columns, int minValue, int maxValue)
{
    double[,] resultMatrix = new double[rows, columns];
    for (int i=0; i<resultMatrix.GetLength(0);i++)
    {
        for (int j=0; j<resultMatrix.GetLength(1);j++)
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1)+ Math.Round(new Random().NextDouble(),1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(double[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]}\t");
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
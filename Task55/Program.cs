// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

int [,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) 
	{
		for (int j = 0; j < matrix.GetLength(1); j++) 
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{	
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
			else Console.Write($"{matrix[i, j], 4} ");
		}	
		Console.WriteLine("]");
    }
}

int [,] ChangeRowColumnsMatrix (int [,] matrix)
{
	int [,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
	for ( int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(0); j++)
			{
				newMatrix[i, j] = matrix[j, i];
			}
		}
	return newMatrix;
}

int [,] matrixRND = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(matrixRND);
Console.WriteLine(String.Empty);
if (matrixRND.GetLength(0) == matrixRND.GetLength(0))
{
int [,] newMatrix = ChangeRowColumnsMatrix(matrixRND);
PrintMatrix(newMatrix);
}
else
{
Console.WriteLine("Количество строк и стобцов не совпадает");
}































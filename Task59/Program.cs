// Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[,] RemoveRowColumnCrossed(int[,] matrix, int removeRow, int removeColumn)
{
	int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
	int m = 0;
	int n = 0;
	for (int i = 0; i < newMatrix.GetLength(0); i++)
	{
		if (i == removeRow) m++;
		for (int j = 0; j < newMatrix.GetLength(1); j++)
		{
			if (j == removeColumn) n++;
			newMatrix[i, j] = matrix[m, n];
			n++;
		}
		m++;
		n = 0;
	}
	return newMatrix;
}

int[] IndexMinVal (int[,] matrix)
{
	int min = matrix[0, 0];
	int indexRow = 0;
	int indexColomn = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i, j] < min)
			{
				min = matrix[i, j];
				indexRow = i;
				indexColomn = j;
			}
		}
	}
	return new int[] {indexRow, indexColomn, min};
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int[,] newMatrix = CreateMatrixRndInt(5, 6, 1, 5);
PrintMatrix(newMatrix);
int [] arraynew = IndexMinVal(newMatrix);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
PrintArray(arraynew);
Console.WriteLine(string.Empty);
int[,] newmatrixnew = RemoveRowColumnCrossed(newMatrix,arraynew[0], arraynew[1]);
Console.WriteLine(string.Empty);
PrintMatrix(newmatrixnew);









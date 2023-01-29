// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int [,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
// {
// 	int[,] matrix = new int[rows, columns];
// 	Random rnd = new Random();

// 	for (int i = 0; i < matrix.GetLength(0); i++) 
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++) 
// 		{
// 			matrix[i, j] = rnd.Next(min, max + 1);
// 		}
// 	}
// 	return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		Console.Write("[");
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 		{	
// 			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
// 			else Console.Write($"{matrix[i, j], 4} ");
// 		}	
// 		Console.WriteLine("]");
//     }
// }

// int [] NewArray01 (int[,] array)
// {
// 	int[] newarray = new int[array.GetLength(0)];
// 	for (int i = 0; i < newarray.Length; i++)
// 	{
// 		newarray[i] = array[0, i];
// 	}
// 	return newarray;
// } 

// int [] NewArray02 (int[,] array)
// {
// 	int[] newarray = new int[array.GetLength(0)];
// 	for (int i = 0; i < newarray.Length; i++)
// 	{
// 		newarray[i] = array[array.GetLength(1) - 1, i];
// 	}
// 	return newarray;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i]);
//     }
//     Console.Write("]");
// }

// int [,] NewMatrix (int[,] matrix, int[] array1, int[] array2)
// {
// 	int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		newmatrix[0, i] = array1[i];
// 		newmatrix[newmatrix.GetLength(1) - 1, i] = array2[i];

// 	}
// 	return newmatrix;
// }

// int[,] newMatrix = CreateMatrixRndInt(5, 5, 1, 9);
// PrintMatrix(newMatrix);
// Console.WriteLine();
// Console.WriteLine();
// int[] array01 = NewArray01(newMatrix);
// PrintArray(array01);
// Console.WriteLine();
// Console.WriteLine();
// int[] array02 = NewArray02(newMatrix);
// PrintArray(array02);
// Console.WriteLine();
// Console.WriteLine();
// int[,] newMatrixVerNew = NewMatrix(newMatrix, array01, array02);
// PrintMatrix(newMatrixVerNew);

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

void ChangeFirstAndLastRows (int[,] matrixForChange)
{
	int firstRow = 0;
	int lastRow = matrixForChange.GetLength(0) - 1;
	for (int i = 0; i < matrixForChange.GetLength(0); i++)
	{
		int temp = matrixForChange[firstRow, i];
		matrixForChange[firstRow, i] = matrixForChange[lastRow, i];
		matrixForChange[lastRow, i] = temp;
	}
}

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 9);

PrintMatrix(matrix);

ChangeFirstAndLastRows(matrix);
Console.WriteLine(string.Empty);
PrintMatrix(matrix);

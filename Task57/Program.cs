// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.
Console.WriteLine();
int [,] firstMatrix = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(firstMatrix);
Console.WriteLine();
int [] firstArray = MatrixToArray(firstMatrix);
PrintArray(firstArray);
Array.Sort(firstArray);
Console.WriteLine();
PrintArray(firstArray);
Console.WriteLine();
Dictionary(firstArray);

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

int [] MatrixToArray (int [,] matrix)
{
	int[] array = new int[matrix.Length];
	int index = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			array[index] = matrix[i, j];
			index++;
		}
	}
	return array;
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

void Dictionary (int [] array)
{
	int number = array[0];
	int count = 1;

	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] == number) count ++;
		else
		{
			Console.WriteLine($"{number} => {count}");
			number = array[i];
			count = 1;
		}
	}
	Console.WriteLine($"{number} => {count}");
}



























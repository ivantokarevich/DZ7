// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/* Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
FillArray(m, n, array);
PrintArray(array);

void FillArray(int m, int n, double [,] array){
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(-99, 100)/10.0;
		}
	}
}


void PrintArray(double [,] array){
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}
 */


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



/* int[,] array = FillArray(5, 5);
PrintArray(array);
Console.WriteLine("Введите индекс строки, искомого числа: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца, искомого числа: ");
int n = Convert.ToInt32(Console.ReadLine());
SearchElement(m, n, array);



int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

void SearchElement(int m, int n, int[,] array)
{
	if (array.GetLength(0) > m && array.GetLength(1) > n  && m >= 0 && n >= 0)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (i == m && j == n) Console.WriteLine("Искомый элемент: " + array[i, j]);
			}
		}
	}
	else Console.WriteLine("Нет такого элемента");
} */



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = FillArray(5, 5);
PrintArray(array);
Average(array);


int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

void Average(int[,] array)
{

	for (int j = 0; j < array.GetLength(1); j++)
	{
		double avg = 0;
		for (int i = 0; i < array.GetLength(0); i++)
		{
			avg += array[i, j];
		}
		avg /= array.GetLength(0);
		Console.WriteLine("среднее арифметическое элементов " + (j + 1) + " столбца: " + avg);
	}
}




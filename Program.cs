// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int size = 12;

 
int[] GetRandomArray(int size, int begin = 0, int last = 100)
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last + 1);
    }

    return arr;
}

int[] arr = GetRandomArray(6, 100, 1000);
System.Console.WriteLine(String.Join(",", arr));


int count = 0;

for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 )
        {
        count = count + 1;
        }
    }
 System.Console.Write(count);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int size, int begin = 0, int last = 100)
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last + 1);
    }

    return arr;
}

int[] arr = GetRandomArray(10, -100 , 100);
System.Console.WriteLine(String.Join(",", arr));

// int GetSum(int[] arr)
// {
    int sum = 0;
    
    for (int i = 1; i < arr.Length - 2; i++)
    {
        
        {
        sum = sum + arr[i + 2];
        }
    }
 System.Console.Write(sum);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



double[] GetRandomArray(int size, int begin = 0, int last = 100)
{
    double[] arr = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last + 1);
    }

    return arr;
}

double[] arr = GetRandomArray(10, 0 , 100);
System.Console.WriteLine(String.Join(",", arr));


double max= arr[0];
for (int i = 0; i < arr.Length; i++)
{
	if (max < arr[i])
	{
		max = arr[i];
	}
}
 double min = arr[0];
 for (int i = 0; i < arr.Length; i++)
 {
if (min > arr[i])
	{
		min = arr[i];
	}   
} 
double result = max - min;  
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(result);


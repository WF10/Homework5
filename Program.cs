// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int N = 8;
int firstN = 100;
int lastN = 1000;
int[] Array = new int[N];
CreatArray(Array);
PrintArray(Array);
Homework5_34(Array);
Console.WriteLine();

void CreatArray(int[] currentArray)
{
    Random rand = new Random();
    for (int step = 0; step < currentArray.Length; step++)
    {
        currentArray[step] = rand.Next(firstN,lastN);
    }
}

void PrintArray(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на экран:");
    for(int step = 0; step < currentArray.Length; step++)
    {
        Console.Write(currentArray[step] + "\t");
    }

    Console.WriteLine();
}

void Homework5_34(int[] currentArray)
{
    int SUMpl = 0;
    int SUMmn = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] %2 == 0)
        {
            SUMpl = SUMpl + 1;
        }
        else
        {
            SUMmn = SUMmn + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"В заданном массиве положительных трёхзначных числел => {SUMpl} <= чётных");
    Console.WriteLine($"В заданном массиве положительных трёхзначных числел => {SUMmn} <= нечётных");
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int N = 10;
int firstN = 10;
int lastN = 100;
int[] Array = new int[N];
CreatArray(Array);
PrintArray(Array);
Homework5_36(Array);
Console.WriteLine();

void CreatArray(int[] currentArray)
{
    Random rand = new Random();
    for (int step = 0; step < currentArray.Length; step++)
    {
        currentArray[step] = rand.Next(firstN,lastN);
    }
}

void PrintArray(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на экран:");
    for(int step = 0; step < currentArray.Length; step++)
    {
        Console.Write(currentArray[step] + "\t");
    }

    Console.WriteLine();
}

void Homework5_36(int[] currentArray)
{
    int SUModd=0;
    for(int i=1; i < currentArray.Length; i++)
    {
        if(i%2 != 0)
        {
            SUModd += currentArray[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элеменотов, стоящих на нечётных позициях, равна: {SUModd}");
}
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
/*
int N = 5;
double[] Array = new double[N];
int fistN = 0;
int lastN = 10;
CreatArray(Array);
PrintArray(Array);
MaxMinNumber(Array);
Console.WriteLine();

void CreatArray(double[] currentArray)
{
    Random rand = new Random();
    for (int step = 0; step < currentArray.Length; step++)
    {
        currentArray[step] = rand.Next(fistN,lastN) + rand.NextDouble();
    }
}

void PrintArray(double[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на экран:");
    for(int step = 0; step < currentArray.Length; step++)
    {
        Console.Write($"{currentArray[step]:N3} \t");
    }

    Console.WriteLine();
}

void MaxMinNumber(double[] currentArray)
{
    double MaxNumber = 0;
    double MinNumber = lastN;
    double Diff;
    for(int i=0; i < currentArray.Length; i++)
    {
        if(currentArray[i] > MaxNumber)
        {
            MaxNumber = currentArray[i];
        }
        if(currentArray[i] < MinNumber)
        {
            MinNumber = currentArray[i];
        }
    }
    Diff = MaxNumber - MinNumber;

    Console.WriteLine($"Максимальное число: {MaxNumber:N3}");
    Console.WriteLine();
    Console.WriteLine($"Минимальное число: {MinNumber:N3}");
    Console.WriteLine();
    Console.WriteLine($"Разность между максимальным {MaxNumber:N3} и минимальным {MinNumber:N3} элементами массива равна: {Diff:N3}");
}
*/


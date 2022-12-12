/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int Power (int num, int numPow)
{
    int res = num;
    for (int current = 1; current < numPow; current++)
    {
        res = res * num;
    }

    return res;
}

Console.Write ("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Power(a,b);

Console.WriteLine ($"A raised to power B power is: {result}");
*/
/*
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int num)
{
    int res = 0;

    while(num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sum (number);

Console.WriteLine($"Sum of digits of {number} is equal to {result}");

*/
/*
//Задача 29 (вариант 1): Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next();
    }

    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " " );
    }
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);
*/

//Задача 29 (вариант 2): Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] InterNumbers(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите {i+1} число: ");
//         array[i] = int.Parse(Console.ReadLine()!);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int check(int[] myArray)
// {
// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         count = count + 1;
// }
// return count;
// }

// int len = InputNum("Введите длину массива: ");
// int[] arr = InterNumbers(len);
// PrintArray(arr);
// int quantity = check(arr);
// Console.WriteLine($"Количество положительных элементов {quantity}");














// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int b1 = InputNum("Введите координату b1: ");
int k1 = InputNum("Введите координату k1: ");
int b2 = InputNum("Введите координату b2: ");
int k2 = InputNum("Введите координату k2: ");

double x = (double) (b2 - b1) / (k1 - k2);
double y = (double) k1*(x) + b1;
    Console.WriteLine($"Точка пересечения ({x:0.00}, {y:0.00})");

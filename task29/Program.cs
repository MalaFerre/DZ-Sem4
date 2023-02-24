// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Enter a number: ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < arr.Length; i++)
{
    System.Console.WriteLine($"{arr[i]} ");
}
System.Console.WriteLine();
}
PrintArray(arr);

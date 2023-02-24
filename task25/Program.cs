// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Веедите число A: ");
int numberA =  Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("Веедите число B: ");
int numberB = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine(Math.Pow(numberA, numberB));

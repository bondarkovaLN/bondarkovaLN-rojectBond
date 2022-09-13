//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите трехзначное число:");
 int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.Write(k < 0 ? "->третьей цифры нет" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());

Console.ReadLine();
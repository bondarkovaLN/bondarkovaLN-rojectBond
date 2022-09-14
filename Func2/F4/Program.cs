//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
ouble a;
double b;
double c;

Console.WriteLine("Программа возведения числа в степень");
Console.WriteLine("Введите число, которое вы хотите возвести в степень:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Спасибо, теперь введите степень, в которую хотите возвести число "+a+":");
b = Convert.ToDouble(Console.ReadLine());

c = Math.Pow(a, b);
Console.WriteLine("Готово! "+a+" в степени "+b+" равно "+c+"!");
Console.ReadLine();

a = Math.Pow(a, b);
Console.WriteLine("Готово! Результат равен "+a+"!");
Console.ReadLine();
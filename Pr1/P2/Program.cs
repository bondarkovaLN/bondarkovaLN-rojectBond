//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("введи первое число:");
int num1 = Convert.ToInt32(Console . ReadLine ());

Console.WriteLine("введи второе число:");
int num2 = Convert.ToInt32(Console . ReadLine ());

Console.WriteLine("введи третье число:");
int num3 = Convert.ToInt32(Console . ReadLine ()); 

if (num1>num2)
{
    
Console.WriteLine(num1);

}
else
{
    Console.WriteLine((num2)); 
    
    }
   if (num1>num3)
{
    
Console.WriteLine("максимальное число-",num1);
 Console.WriteLine(num1);
}
else
{
    Console.WriteLine("максимальное-",(num3)); 
    Console.Write(num3);
}
   
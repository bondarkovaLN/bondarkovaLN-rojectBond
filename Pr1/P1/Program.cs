//напишите программу которая на вход принимает 2 числа и выдает какое число больше, а какое меньше

Console.WriteLine("введи первое число:");
int num1 = Convert.ToInt32(Console . ReadLine ());

Console.WriteLine("введи второе число:");
int num2 = Convert.ToInt32(Console . ReadLine ());

if (num1>num2)
{
    
Console.WriteLine("максимальное число-",num1);
 Console.WriteLine(num1);
}
else
{
    Console.WriteLine("минимальное число-",num2); 
    Console.Write(num2);
    }



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Degree(string num)
{
     int [] thirdNumber = new int[Convert.ToInt32(num)];
   int count = 0;
   while (count < Convert.ToInt32(num))
   {
        thirdNumber[count] = (count + 1) * (count + 1) * (count + 1);
        count ++;
   }
  
    count = 0;
    while (count < thirdNumber.Length)
    {
        Console.Write(thirdNumber[count]);
        count ++;
       
        if (count < thirdNumber.Length)
        {
            Console.Write(", ");
        }
    }
}


Console.Write("Введите натуральное число от 1 до 1000: ");
string numb = Console.ReadLine();

if ( Convert.ToInt32(numb) >= 1 && Convert.ToInt32(numb) <= 1000 ) 
{
     Degree(numb);
}
else
{
    Console.WriteLine("Вы ввели не допустимое число!");
}

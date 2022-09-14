
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); // Задаём размер массива
int [] mass  = new int[n];      // Создаём массив

for (int i = 0; i < n; i++)
  { Console.Write($" Введите {i}й элемент: "); mass[i]= Convert.ToInt32(Console.ReadLine()); }
  
double min = double.MaxValue;
double max = double.MinValue;

foreach (int i in mass)  // Поиск максимального и минимального значения
{
    if (i>max) max = i;
    if (i < min) min = i;
}
Console.WriteLine("Разница между макс и мин: {0}", max - min);
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArrey(int numLengh) // заполняем массив
{
    Random rnd = new Random();
    int[] newArray = new int [numLengh];
    for (int i = 0; i < numLengh; i++)
    {
        newArray[i] = rnd.Next(0, 8);
    }
    return newArray;
}

void PrintArray(int[] arr, int numLengh) // выводим массив на экран
{
    Console.Write("Выводим полученный массив: [");
    for (int i = 0; i < numLengh; i++)
    {
        Console.Write(arr[i]);
        if (i < numLengh - 1) Console.Write(", "); // после каждого (кроме последнего) члена массива выводим запятую
    }
    Console.WriteLine("]"); //закрываем квадратную скобку после последнего члена массива
}

Console.Write("Введите размер массива из 8 цифр от 0 до 20 через запятую: "); // ограничил что бы всё умещалось в одну строку
int lengh = Convert.ToInt32(Console.ReadLine());
if (lengh > 0 && lengh < 21) // размер массива из нужного диапазона?
{
    int [] arr = GetArrey(lengh);
    PrintArray(arr, lengh);
}
else Console.WriteLine("Не верный размер массива");
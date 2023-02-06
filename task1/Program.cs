// Задача 24: Напишите программу, которая 
// принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("введите число2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("введите число3: ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine($"сумма цифр = {GetSumNums(num)}");
Console.WriteLine($"сумма цифр = {GetSumNums(num2)}");
Console.WriteLine($"сумма цифр = {GetSumNums(num3)}");
int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        Console.Write(sum+" ");
        number--;
    }
    return sum;
}

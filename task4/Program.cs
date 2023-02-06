// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
uint num = uint.Parse(Console.ReadLine());
Console.WriteLine($"произведение чисел от 1 до {num} равно: {GetProductNums(num)}");
uint GetProductNums(uint num)
{
    uint product = 1;
    // for (int i = 1; i <= num; i++)
    // {
    //     product *= i;
    // }
    while (num>=1)
{
    product*=num--;
   
}
    return product;
}


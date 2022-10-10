// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

link1:
Console.WriteLine("Ведите трёхзначное число:");
int num = int.Parse(Console.ReadLine()!);

int a = num;
int digits = 0;


while (a > 0)
{
    digits++;
    a = a / 10;
}
if (digits < 3 || digits > 3)
{
    Console.WriteLine("Введено не трёхзначное число! Введите заново!");
    goto link1;
}
else
{
    int numA = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра из числа {num}, цифра: {numA}");
}

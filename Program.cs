Console.Clear();


Console.WriteLine("Выходной ли день недели?:");
link1:
Console.WriteLine("Введите цифру дня недели от 1 до 7:");
int num = int.Parse(Console.ReadLine()!);

if (num == 6 || num == 7)
{
    Console.WriteLine($"да! {num} - выходной");
}
else if (num < 1 || num > 7)
{
    Console.WriteLine("В неделе 7 дней! Введите цифру дня недели заново!");
    goto link1;
}
else
{
    Console.WriteLine($"нет! {num} - рабочий");
}
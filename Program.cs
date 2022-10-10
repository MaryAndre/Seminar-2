 Console.Clear();

 Console.WriteLine("Ведите число:");
 int num = int.Parse(Console.ReadLine()!);

 int a = num;
 int digits = 0; // кол-во цифр

 while (a > 0)
 {
     digits++;
     a = a / 10;
 }
 if (digits < 3)
 {
     Console.WriteLine("Третьей цифры нет!!!");
 }
 else
 {
     int i = 0;
     while (i < digits - 3)
     {
         num = num / 10;
         i++;
     }
     num = num % 10;
     Console.WriteLine($"Третья цифра: {num}");
 }
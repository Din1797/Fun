// Задача 13

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99)
    {
        int count = Number;
        while (count > 999)
            {
                count /= 10;
            }
        Console.WriteLine($"третья цифра " + count % 10);
    }
else 
Console.Write("нет третьей цифры ");

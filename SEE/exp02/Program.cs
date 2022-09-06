// задача 15

Console.Write("Введите цифру день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("нет такого дня недели!");
  }
  else Console.WriteLine("не выходной день ");
}

CheckingTheDayOfTheWeek(dayNumber);

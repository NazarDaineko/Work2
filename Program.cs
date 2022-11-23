//
string fullName = "Иванов Никита Иванович";
int age = 14;
string Email = "IvanovNikita@gmail.com";
double matPoints = 8.3;
double progPoints = 10.0;
double physPoints = 6.6;
string pattern = "Имя: {0} \nВозраст: {1} \nПочта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
double pointsSum = matPoints + progPoints + physPoints;
double arithmeticMeanPoints = pointsSum / 3; //Не знаю, почему, но пишет 8.299999999999999

Console.WriteLine("Нажмите Enter, чтобы начать");
Console.ReadLine();

#region Task1
Console.WriteLine(pattern,
                  fullName,
                  age,
                  Email,
                  progPoints,
                  matPoints,
                  physPoints);
Console.ReadLine();
#endregion

#region Task2
Console.WriteLine("Сумма баллов: " + pointsSum);
Console.WriteLine("Средний балл: " + arithmeticMeanPoints);
Console.ReadLine();
#endregion
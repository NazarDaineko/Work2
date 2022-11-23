//
string fullName = "Иванов Никита Иванович";
int age = 14;
string Email = "IvanovNikita@gmail.com";
double matPoints = 8.3;
double progPoints = 10.0;
double physPoints = 5.6;
string pattern = "Имя: {0} \nВозраст: {1} \nПочта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

Console.WriteLine("Нажмите Enter, чтобы вызвать блок 1.");
Console.ReadLine();
Console.WriteLine(pattern,
                  fullName,
                  age,
                  Email,
                  progPoints,
                  matPoints,
                  physPoints);
Console.ReadLine();

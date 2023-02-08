//проверка числа на простость
bool Prosto (int a)
{
    if (a == 1) return false;
    else if ((a / 7 > 1) & (a % 7 == 0)) return false;
    else if ((a / 5 > 1) & (a % 5 == 0)) return false;
    else if ((a / 3 > 1) & (a % 3 == 0)) return false;
    else if ((a / 2 > 1) & (a % 2 == 0)) return false;

    else return true;
}

int a;

//ввод числа с проверкой
Console.WriteLine("дай число: ");
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Дай число! ");
}

//вызов функции
if (Prosto(a))
    Console.WriteLine("Число простое.");
else Console.WriteLine("Число не простое.");

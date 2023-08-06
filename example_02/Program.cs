// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
int i = 0;
bool IsPol = true;
while(i<number.Length/2 && IsPol)
{
    if( number[i] != number[number.Length - i - 1])
    {
        IsPol= false;
    }
    i++;
}
if (IsPol)
{
    Console.WriteLine($"Число {number} Палиндром");
}
else
{
    Console.WriteLine($"Число {number} Не палиндром");
}
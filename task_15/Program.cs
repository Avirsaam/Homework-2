/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

string [] daysOfWeek = {
    "Понедельник", 
    "Вторник", 
    "Среда", 
    "Четверг", 
    "Пятница", 
    "Суббота", 
    "Воскресенье"
};


bool isWeekend(int dayNumber)
{
    return dayNumber == 6 || dayNumber == 7;
}

Console.Clear();
Console.WriteLine("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number <= 0)
{
    Console.WriteLine($"Ошибка ввода, в неделе {daysOfWeek.Length} дней");
}
else
{
    if (isWeekend(number)) Console.Write("Да, ");    
    else Console.Write("Нет, ");

    Console.Write(daysOfWeek[number - 1] + " это ");

    if (!isWeekend(number)){
        Console.Write("не ");
    }

    Console.WriteLine("выходной день");    
}


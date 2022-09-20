/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumber()
{
    Console.WriteLine("Введите число, обозначающее день недели");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

int number = GetNumber();

if (number == 6 || number == 7)
    Console.WriteLine("да");
else
if (number >= 1 && number <= 5)
    Console.WriteLine("нет");
else
    Console.WriteLine("Значение не верное");


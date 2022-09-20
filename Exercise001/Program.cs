/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int num = new Random().Next(100, 1000);

int FindDigit(int num)
{
    num = new Random().Next(100, 1000);
    Console.WriteLine(num);
    int result = num % 100;
    result = result / 10;
    return result;
}

Console.WriteLine(FindDigit(num));
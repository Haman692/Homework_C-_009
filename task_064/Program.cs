// // ## Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumberInversion(int num)
{
    System.Console.Write(num + " ");
    if(num > 1)
        NumberInversion(num - 1);
}


int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = AddNumber("Введите число");
NumberInversion(number);
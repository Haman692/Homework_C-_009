// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersInBetween(int numA, int numB)
{
    if(numA == numB)
        return numB;
    return SumNumbersInBetween(numA + 1, numB) + numA;
}

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int numberM = AddNumber("Введите первое число");
int numberN = AddNumber("Введите второе число");
if(numberM < numberN)
{
    int sum = SumNumbersInBetween(numberM, numberN);
    System.Console.WriteLine(sum);
}
else
    System.Console.WriteLine("Некоректный ввод");
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int numA = SetNumber("число");
int sum = GetSumAllToNumberA(numA);
Print(sum);

int SetNumber(string str)
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int GetSumAllToNumberA(int numMetodA)
{
    int sumM = 0;
    for (int i = numMetodA; i > 0; i=i/10)
    {
        sumM = sumM + i%10;
    }
     return sumM;
}

void Print(int num)
{
    System.Console.WriteLine($"Суммa цифр = {num}");
}
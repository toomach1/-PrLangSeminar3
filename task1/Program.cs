// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

int numA = SetNumber("A");

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
    int sum = 0;
    for (int i = 0; i <= numMetodA; i++)
    {
        sum += i;
    }
     return sum;
}

void Print(int num)
{
    System.Console.WriteLine($"number = {num}");
}

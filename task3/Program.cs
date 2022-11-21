// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.


int num = SetNumber("число N");

int multi = 1;
for (int i = 1; i <=num; i++)
{
    multi *= i;
}

Print(multi);




int SetNumber(string str)
{

    System.Console.WriteLine($"Введите {str}");
    num = int.Parse(Console.ReadLine());

    return num;
}

void Print(int multi)
{
    System.Console.WriteLine($"произведение чисел от 1 до {num} = {multi}");
}
// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.


int num = SetNumber("число");

int multi = 1;
for (int i = 1; i <=num; i++)
{
    multi *= i;
}

System.Console.WriteLine(multi);




int SetNumber(string str)
{

    System.Console.WriteLine($"Введите {str}");
    num = int.Parse(Console.ReadLine());

    return num;
}


// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numA = SetNumber("число A");
int numB = SetNumber("число B");
int rais = RaisNumAtoPow(numA,numB);



System.Console.WriteLine($"{numA} в степени {numB} = {rais}");

int SetNumber(string str)
{
    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int RaisNumAtoPow(int numMetodA, int numMetodB)
{
    int multi = 1;
    for (int i = 1; i <= numMetodB; i++)
    {
        multi = numMetodA * multi;
    }
    return multi;
}
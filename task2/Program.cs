// //Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int NumA = SetNumber("число");

int count = CountNum(NumA);

System.Console.WriteLine($"количество цифр в числе = {count}");



int SetNumber(string str)
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int CountNum(int NumAMetod)
{   
    int count = 0;
    while(NumAMetod>0)
    {
        
        count ++ ;
        NumAMetod = NumAMetod/10;
    }
    return count;
}    
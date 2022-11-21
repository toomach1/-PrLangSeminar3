// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

int[]array={0,0,0,0,0,0,0,0};
Random rnd = new Random();
for (int i = 0; i <= 7; i++)
{
    array[i] = rnd.Next(0,2);
    System.Console.Write(array[i]);
}
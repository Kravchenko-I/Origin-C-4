// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();
int[] arr = new int[8];
 RandomArray(arr);
 PrintArray(arr);

 void PrintArray(int[] array)
 {
    for (int i =0;i<8;i++)
    {
        Console.Write(array[i]+", ");
    }
 }

void RandomArray(int[]array)
{
    for(int i = 0;i<8;i++)
    {
        array[i]=new Random().Next(0, 2);
    }
}
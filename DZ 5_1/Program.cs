//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // [-9, 10) > -9 до 9
    }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int sumofElements(int[] array, int leftRange, int rightRange)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum=sum + array[i];
    }
return sum;
}
var myArray = GenerateArray(8, 10, 99);
PrintArray(myArray);
Console.WriteLine(sumofElements(myArray, 10, 99));
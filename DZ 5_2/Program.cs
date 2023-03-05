// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] GenerateArray()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
    return array;
}

void PrintArray(double[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


var myArray = GenerateArray();
PrintArray(myArray);



class MinMaxValue
{
    double maxValue(double[] array)
    {
        double max = Int32.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    double minValue(double[] array)
    {
        double min = Int32.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > min)
            {
                min = array[i];
            }
        }
        return min;
    }
}


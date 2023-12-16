void FillArray (double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100)+ new Random().NextDouble();
               
    }
}

void PrintArray(double[] num)
{
    for (int i =0; i < num.Length; i++)
    {
        Console.Write(num[i]+ " ");
    }
}

double GetMinArray(double[] array)
{
    double min = array[0];
    foreach (double a in array)
    {
        if(min > a) min = a;
    }
    return min;
}

double GetMaxArray(double[] array)
{
    double max = array[0];
    foreach (double b in array)
    {
        if(max < b) max = b;
    }
    return max;
}

double GetResult(double min, double max)
{
    double result = max - min;
    return result;
}

Console.WriteLine("введите длинну массива");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double [N];

FillArray (array);
PrintArray (array);

Console.WriteLine(" ");

Console.WriteLine($"Максимальное значение массива = {GetMaxArray(array)}");

Console.WriteLine($"Минимальное значение массива = {GetMinArray(array)}");

Console.WriteLine($"Разница между минимальным и максимальным значением = {GetResult (GetMinArray(array), GetMaxArray(array))}");


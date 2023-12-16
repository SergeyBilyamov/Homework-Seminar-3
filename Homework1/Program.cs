void FillArray (int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100);        
    }
}
void PrintArray(int[] num)
{
    for (int i =0; i < num.Length; i++)
    {
        Console.Write(num[i]+ " ");
    }
}


int [] array = new int [10];
int count = 0;
FillArray (array);
PrintArray (array);

Console.WriteLine(" ");

foreach (int elements in array)
{
    if ((elements > 20) && (elements < 90))
    {
        count = count + 1;
    }
} 
Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [20,90] = {count}");
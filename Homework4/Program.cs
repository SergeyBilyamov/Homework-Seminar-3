

void PrintArray(int[] num)
{
    for (int i =0; i < num.Length; i++)
    {
        Console.Write(num[i]+ " ");
    }
}

int number = new Random().Next(1,100001);   
Console.WriteLine($"Дано число {number}");

int size = number%10;

int[] b = new int[size];
for( int i=0; i< b.Length; i++)
{
    int count = number % 10;
    number= number/10;
    b[i] = count;
}

PrintArray(b);





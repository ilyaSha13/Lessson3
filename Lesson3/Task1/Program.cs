
void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }

}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}

int GetSumOfElements(int[] array)
{
    int sum = 0;
    foreach (int e in array)
    {
        sum = sum + e;
    }
    return sum;
}

int GetProductOfElements(int[] numbers)
{
    int product = 1;
    foreach (int e in numbers)
    {
        product = product * e;
    }
    return product;
}

int n = 10;
int[] arr = new int[n];

FillArray(arr);
PrintArray(arr);

int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);

Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine(product);
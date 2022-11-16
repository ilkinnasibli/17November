int[] numbers = { 1, 2, 3, 4, 5 };
reSize(ref numbers, 9);
Console.WriteLine(numbers.Length);
 static void reSize(ref int[] arr, int newSize)
{
    int[] reSizeArr = new int[newSize];
    for (int i = 0; i < newSize; i++)
    {
        if (i < arr.Length)
        {
            reSizeArr[i] = arr[i];
        }
        else
        {
            reSizeArr[i] = 0;
        }
    }
    arr = reSizeArr;
}
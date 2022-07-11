int[] Array ()
{
    int size = 10;
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10,11);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
            Console.Write(array[i] + " ");
    
    }
Console.WriteLine();
}

int SumOddPosElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i]; 
    }
    return sum;
}

int[] myArray = Array();
ShowArray(myArray);
Console.Write("Sum of odd position element is: " + SumOddPosElements(myArray));
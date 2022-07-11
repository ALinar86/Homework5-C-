double[] CreateRandomArray(int size)

{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = (new Random().Next(1, 10) + new Random().NextDouble());
    }

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(); 
}

double DiffMinMax(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
  {
        if (maxNumber < array[i])
        {
              maxNumber = array[i];
        }
        if (minNumber > array[i])
        {
             minNumber = array[i];
        }
  }
    double difference = maxNumber - minNumber;
    return difference;
  }

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] MyArray = CreateRandomArray(size);
ShowArray(MyArray);
Console.WriteLine("The difference between the maximum and minimum elements is: " + DiffMinMax(MyArray));
class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10);
        PrintArray(array);
        int secondLargest = FindSecondLargest(array);
        Console.WriteLine($"Second largest: {secondLargest}");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 101);
        }
        return array;
    }

    static int FindSecondLargest(int[] array)
    {
        if (array.Length < 2)
        {
            throw new ArgumentException("Array must contain at least two elements.");
        }

        int first = int.MinValue, second = int.MinValue;
        foreach (int number in array)
        {
           if (number > first)
           {
            second = first;
            first = number;
           }
           else if (number > second && number < first)
           {
            second = number;
           }    
        }
        
        return second;
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

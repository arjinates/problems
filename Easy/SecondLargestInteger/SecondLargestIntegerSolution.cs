namespace Problems.Easy.SecondLargestInteger;
public class SecondLargestIntegerSolution
{
    public int GenerateRandomArrayAndReturnAnswer(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 101);
        }
        PrintArray(array);
        return FindSecondLargest(array);;
    }

    public static int FindSecondLargest(int[] array)
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

    public static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
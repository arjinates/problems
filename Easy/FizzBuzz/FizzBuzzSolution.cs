public class FizzBuzzSolution
{
    public IList<string> FizzBuzz(int n)
    {
        var responseList = new List<string>(n);
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                responseList.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                responseList.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                responseList.Add("Buzz");
            }
            else
            {
                responseList.Add(i.ToString());
            }
        }
        return responseList;
    }
}

int x = 20;

string FizzBuzz(int x)
{
    List<string> resultList = new List<string>();
    for (int i = 1; i <= x; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            resultList.Add(i + " FizzBuzz");
            //Console.WriteLine(i + " FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            resultList.Add(i + " Fizz");
            //Console.WriteLine(i + " Fizz");
        }
        else if (i % 5 == 0)
        {
            resultList.Add(i + " Buzz");
            //Console.WriteLine(i + " Buzz");
        }
        else
        {
            resultList.Add(i.ToString());
            //Console.WriteLine(i);
        }
    }
    
    return string.Join(", ", resultList);;
}

Console.WriteLine(FizzBuzz(x));




/*Console.WriteLine("FizzBuzz using switch expression");
for (int i = 1; i <= x; i++)
{
    string result = (i % 3, i % 5) switch
    {
        (0, 0) => i + " FizzBuzz",
        (0, _) => i + " Fizz",
        (_, 0) => i + " Buzz",
        _ => i.ToString()
    };
    Console.WriteLine(result);
}



Console.WriteLine("FizzBuzz using switch with when clause");
for (int i = 1; i <= x; i++)
{
    string result = i switch
    {
        int n when n % 3 == 0 && n % 5 == 0 => i + " FizzBuzz",
        int n when n % 3 == 0 => i + " Fizz",
        int n when n % 5 == 0 => i + " Buzz",
        _ => i.ToString()
    };
    Console.WriteLine(result);
}*/





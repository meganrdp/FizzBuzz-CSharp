namespace FizzBuzz;

internal class Program
{
    static bool IsDivisibleBy(int numerator, int denomoinator)
    {
        return numerator % denomoinator == 0;
    }
    static void Fizzbuzz()
    {
        for (int i = 0; i <= 100; i++)
        {
            string result = "";

            if (IsDivisibleBy(i,3))
            {
                result += "Fizz";
            }

            if (IsDivisibleBy(i,5))
            {
                result += "Buzz";
            }

            if (IsDivisibleBy(i,7))
            {
                result += "Bang";
            }

            if (IsDivisibleBy(i,11))
            {
                result += "Bong";
            }
            
            if (result == "")
            {
                result = i.ToString();
            }

            Console.WriteLine(result);
           
        }
        Console.ReadLine();
    }
    
    static void Main(string[] args)
    {
        Fizzbuzz();
    }
}

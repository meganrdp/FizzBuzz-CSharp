namespace FizzBuzz;

internal class Program
{
    static bool IsDivisibleBy(int numerator, int denomoinator)
    {
        return numerator % denomoinator == 0;
    }

    private static int IsFoundLetter(List<string> message, string letter)
    {
        int result = -1;
        for (int i = 0; i < message.Count(); i++)
        {
            if (message[i][0].ToString() == "B")
            {
                result = i;
                break;
            }
        }
        return result;
    }

    
    static void Fizzbuzz()
    {
        Console.WriteLine("Please enter a maximum number: ");
        int maxNumChoice = Convert.ToInt32(Console.ReadLine());

        List<string> result = new List<string>();
        
        for (int i = 1; i <= maxNumChoice; i++)
        {
            result.Clear();

            if (IsDivisibleBy(i,3))
            {
                result.Add("Fizz");
            }

            if (IsDivisibleBy(i,5))
            {
                result.Add("Buzz");
            }

            if (IsDivisibleBy(i,7))
            {
                result.Add("Bang");
            }

            if (IsDivisibleBy(i,11))
            {
                result.Add("Bong");
            }

             if (IsDivisibleBy(i,13))
            {
                  if (result.Count > 0)
                       {
                           int position = IsFoundLetter(result, "B");
                           if (position == -1) result.Add("Fezz");
                           else result.Insert(position, "Fezz");
                       }
                       else
                       {
                           result.Clear();
                           result.Add("Fezz");
                       }

            }

            if (IsDivisibleBy(i,17))
            {
                result.Reverse();                          
            }
            
            if (result.Count == 0)
            {
                result.Add(i.ToString());
            }

            Console.WriteLine(string.Join("", result));
           
        }
        Console.ReadLine();
    }
    
    static void Main(string[] args)
    {
        Fizzbuzz();
    }
}

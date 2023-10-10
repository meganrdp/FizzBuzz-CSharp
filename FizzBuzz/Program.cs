namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz()
    {
        for (int i = 0; i <= 100; i++)
        {

            if (i % 3 == 0) 
            {
                Console.WriteLine("fizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();
    }
    
    static void Main(string[] args)
    {
        Fizzbuzz();
    }
}

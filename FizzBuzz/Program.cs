namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz()
    {
        for (int i = 0; i <= 100; i++)
        {
            ifConsole.Write(i);
        }
        Console.ReadLine();
    }
    
    static void Main(string[] args)
    {
        Fizzbuzz();
    }
}

using System;

class StarPattern
{
    public void PrintTriangularPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StarPattern starPattern = new StarPattern();

        int n = 5;
        Console.WriteLine("Triangular Star Pattern:");
        starPattern.PrintTriangularPattern(n);
    }
}

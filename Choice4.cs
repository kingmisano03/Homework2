using System;

class Program
{
    static void Main()
    {
        
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        
        int[] population = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        
        int maxCustomers = 0;


        for (int i = 0; i < N; i++)
        {
            int sum = 0;

          
            for (int j = i; j <= i + K && j < N; j++)
            {
                sum += population[j];
            }

            
            maxCustomers = Math.Max(maxCustomers, sum);
        }

        
        Console.WriteLine(maxCustomers);
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the row number of Pascal's triangle: ");
        int rowNumber = int.Parse(Console.ReadLine());

        if (rowNumber < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            return;
        }

        for (int i = 0; i <= rowNumber; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int coefficient = CalculateCoefficient(i, j);
                Console.Write(coefficient + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculateCoefficient(int row, int column)
    {
        if (column == 0 || column == row)
            return 1;
        else
            return CalculateCoefficient(row - 1, column - 1) + CalculateCoefficient(row - 1, column);
    }
}

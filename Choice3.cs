using System;

class Program
{
    static void Main()
    {
        float[][] A = null;
        float[][] B = null;

        while (true)
        {
            Console.WriteLine("Enter '+' or '-' to perform an operation, or any other character to exit:");
            char operation = Console.ReadLine()[0];

            if (operation != '+' && operation != '-')
            {
                break;
            }

            Console.WriteLine("Enter the size of the matrix (m n):");
            string[] sizeInput = Console.ReadLine().Split(' ');
            int m = int.Parse(sizeInput[0]);
            int n = int.Parse(sizeInput[1]);

            if (operation == '+')
            {
                A = new float[m][];
                B = new float[m][];

                Console.WriteLine("Enter the elements of matrix A:");
                for (int i = 0; i < m; i++)
                {
                    A[i] = new float[n];
                    string[] rowInput = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        A[i][j] = float.Parse(rowInput[j]);
                    }
                }

                Console.WriteLine("Enter the elements of matrix B:");
                for (int i = 0; i < m; i++)
                {
                    B[i] = new float[n];
                    string[] rowInput = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        B[i][j] = float.Parse(rowInput[j]);
                    }
                }

                float[][] result = AddMatrices(A, B);
                Console.WriteLine("Result of A + B:");
                PrintMatrix(result);
            }
            else if (operation == '-')
            {
                A = new float[m][];
                B = new float[m][];

                Console.WriteLine("Enter the elements of matrix A:");
                for (int i = 0; i < m; i++)
                {
                    A[i] = new float[n];
                    string[] rowInput = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        A[i][j] = float.Parse(rowInput[j]);
                    }
                }

                Console.WriteLine("Enter the elements of matrix B:");
                for (int i = 0; i < m; i++)
                {
                    B[i] = new float[n];
                    string[] rowInput = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        B[i][j] = float.Parse(rowInput[j]);
                    }
                }

                float[][] result = SubtractMatrices(A, B);
                Console.WriteLine("Result of A - B:");
                PrintMatrix(result);
            }
        }
    }

    static float[][] AddMatrices(float[][] A, float[][] B)
    {
        int m = A.Length;
        int n = A[0].Length;
        float[][] result = new float[m][];

        for (int i = 0; i < m; i++)
        {
            result[i] = new float[n];
            for (int j = 0; j < n; j++)
            {
                result[i][j] = A[i][j] + B[i][j];
            }
        }

        return result;
    }

    static float[][] SubtractMatrices(float[][] A, float[][] B)
    {
        int m = A.Length;
        int n = A[0].Length;
        float[][] result = new float[m][];

        for (int i = 0; i < m; i++)
        {
            result[i] = new float[n];
            for (int j = 0; j < n; j++)
            {
                result[i][j] = A[i][j] - B[i][j];
            }
        }

        return result;
    }

    static void PrintMatrix(float[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

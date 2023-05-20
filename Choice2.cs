using System;

class Program
{
    static void Main()
    {
        bool processAnotherSequence = true;

        while (processAnotherSequence)
        {
            Console.Write("Enter the DNA sequence (half): ");
            string dnaSequence = Console.ReadLine();

            if (IsValidSequence(dnaSequence))
            {
                Console.WriteLine("Current half DNA sequence: " + dnaSequence);

                Console.Write("Do you want to replicate it? (Y/N): ");
                char choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (choice == 'Y')
                {
                    string replicatedSequence = ReplicateSequence(dnaSequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char anotherChoice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (anotherChoice == 'N')
            {
                processAnotherSequence = false;
            }
            else if (anotherChoice != 'Y')
            {
                Console.WriteLine("Please input Y or N.");
            }

            Console.WriteLine();
        }
    }

    static bool IsValidSequence(string sequence)
    {
        foreach (char basePair in sequence)
        {
            if (basePair != 'A' && basePair != 'T' && basePair != 'C' && basePair != 'G')
            {
                return false;
            }
        }

        return true;
    }

    static string ReplicateSequence(string sequence)
    {
        string replicatedSequence = "";

        foreach (char basePair in sequence)
        {
            if (basePair == 'A')
            {
                replicatedSequence += 'T';
            }
            else if (basePair == 'T')
            {
                replicatedSequence += 'A';
            }
            else if (basePair == 'C')
            {
                replicatedSequence += 'G';
            }
            else if (basePair == 'G')
            {
                replicatedSequence += 'C';
            }
        }

        return replicatedSequence;
    }
}

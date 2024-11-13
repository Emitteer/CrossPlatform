namespace DefaultNamespace;

using System;

class Program
{
    static void Main()
    {
        try
        {
            const string inputFilePath = "INPUT.TXT";
            const string outputFilePath = "OUTPUT.TXT";

            // Create an instance of CyclicDistanceCalculator
            CyclicDistanceCalculator calculator = new CyclicDistanceCalculator(inputFilePath);

            // Calculate the total cyclic distance
            int result = calculator.CalculateTotalCyclicDistance();

            // Write the result to the output file
            calculator.WriteOutput(outputFilePath, result);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
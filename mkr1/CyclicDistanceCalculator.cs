namespace DefaultNamespace;

using System;
using System.IO;

public class CyclicDistanceCalculator
{
    private string sa;
    private string sb;

    public CyclicDistanceCalculator(string filePath)
    {
        ReadInput(filePath);
    }
    
    private void ReadInput(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
            {
                throw new Exception("INPUT.TXT must contain exactly two lines.");
            }

            sa = lines[0].Trim();
            sb = lines[1].Trim();

            if (sa.Length != sb.Length)
            {
                throw new Exception("The strings must be of equal length.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading input: " + e.Message);
            throw;
        }
    }
    
    private int CyclicDistance(char char1, char char2)
    {
        int distance = Math.Abs(char1 - char2);
        return Math.Min(distance, 26 - distance);
    }
    
    public int CalculateTotalCyclicDistance()
    {
        int totalDistance = 0;

        for (int i = 0; i < sa.Length; i++)
        {
            totalDistance += CyclicDistance(sa[i], sb[i]);
        }

        return totalDistance;
    }
    
    public void WriteOutput(string outputFilePath, int result)
    {
        try
        {
            File.WriteAllText(outputFilePath, result.ToString());
            Console.WriteLine("The result has been written to " + outputFilePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error writing output: " + e.Message);
            throw;
        }
    }
}
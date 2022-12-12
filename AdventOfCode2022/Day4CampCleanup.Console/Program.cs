using System.Globalization;

namespace Day4CampCleanup.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read entire text file content in one string  
            string[] text = File.ReadAllLines("input.txt");
            int totalScore = 0;

            List<RangePair> rangePairs = new List<RangePair>();

            for (int i = 0; i < text.Length; i++)
            {
                string line = text[i];
                string[] pairArray = line.Split(",");

                string[] left = pairArray[0].Split("-");
                string[] right = pairArray[1].Split("-");

                RangePair pair = new RangePair();

                pair.Left.SetRange(Convert.ToInt32(left[0]), Convert.ToInt32(left[1]));
                pair.Right.SetRange(Convert.ToInt32(right[0]), Convert.ToInt32(right[1]));

                if (pair.CheckIfOneContainsTheOther())
                {
                    totalScore++;
                }
            }
            System.Console.WriteLine(totalScore);
        }
    }
}
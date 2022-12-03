using Day2RockPaperScissor;

namespace Day2RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read entire text file content in one string  
            string[] text = File.ReadAllLines("input.txt");


            var calculator = new SituationOutcomeType.RockPaperScissorsScoreCalculator();
            foreach (string line in text)
            {
                string[] columns = line.Split(' ');
                calculator.AddRound(columns[1], columns[0]);
            }

            Console.WriteLine(calculator.CalculateRounds());
        }
    }
}
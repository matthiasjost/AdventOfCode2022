namespace Day2RockPaperScissors.Console
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
                calculator.AddRound(columns[0], columns[1]);
            }

            System.Console.WriteLine(calculator.CalculateRounds());
        }
    }
}
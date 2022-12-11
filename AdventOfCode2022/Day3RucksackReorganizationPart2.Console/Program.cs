namespace Day3RucksackReorganizationPart2.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read entire text file content in one string  
            string[] text = File.ReadAllLines("input.txt");
            int totalScore = 0;

            RucksackReorganizationList rucksackList = new RucksackReorganizationList();

            for (int i = 0; i < text.Length; i++)
            {
                if( i %3 == 2)
                {
                    rucksackList.AddRucksack(text[i], text[i-1], text[i-2]);
                }
            }

            foreach (RucksackReorganizationItem rucksackItem in rucksackList.RucksackList)
            {
                rucksackItem.FindWrongStored();
                totalScore += rucksackItem.CalculateWrongSortedPriority();
            }
            System.Console.WriteLine(totalScore);
        }
    }
}
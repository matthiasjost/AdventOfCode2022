using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3RucksackReorganizationPart2.Console
{
    public class RucksackReorganizationList
    {
        public List<RucksackReorganizationItem> RucksackList { get; set; } = new List<RucksackReorganizationItem>();
        public RucksackReorganizationList()
        {
        }
        public void AddRucksack(string firstContents, string secondContents, string thirdContents)
        {
            RucksackReorganizationItem rucksack = new RucksackReorganizationItem();
            rucksack.StoreInThreeRucksacks(firstContents, secondContents, thirdContents);
            RucksackList.Add(rucksack);
        }
    }
}

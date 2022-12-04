using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3RucksackReorganization.Console
{
    public class RucksackReorganizationList
    {
        public List<RucksackReorganizationItem> RucksackList { get; set; } = new List<RucksackReorganizationItem>();
        public RucksackReorganizationList()
        {
            
        }
        public void AddRucksack(string content)
        {
            RucksackReorganizationItem rucksack = new RucksackReorganizationItem();
            rucksack.StoreInCompartment(content);
            RucksackList.Add(rucksack);
        }
    }
}

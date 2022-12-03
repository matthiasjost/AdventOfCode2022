using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Day3RucksackReorganization.Console
{
    public class Rucksack
    {
        public class RucksackCompartment
        {
            public char[] Content { get; set; }
            public char[] GetDistinctItemTypes()
            {
                return Content.Distinct().ToArray();
            }
        }
        public Rucksack(string allContents)
        {
            string first = allContents.Substring(0, allContents.Length / 2);
            string second = allContents.Substring(allContents.Length / 2, allContents.Length / 2);
            FirstCompartment = new() { Content = first.ToCharArray() };
            SecondCompartment = new() { Content = second.ToCharArray() };
        }

        public RucksackCompartment FirstCompartment { get; set; }
        public RucksackCompartment SecondCompartment { get; set; }
        public char[] WrongSortedTypes { get; set; }

        public void FindWrongSortedTypes()
        {
            char[] firstTypes = FirstCompartment.GetDistinctItemTypes();
            char[] secondTypes = SecondCompartment.GetDistinctItemTypes();

            char[] combinedArray = new char[firstTypes.Length + secondTypes.Length];
            Array.Copy(firstTypes, combinedArray, firstTypes.Length);
            Array.Copy(secondTypes, 0, combinedArray, firstTypes.Length, secondTypes.Length);

            char[] duplicates = combinedArray.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToArray();

            WrongSortedTypes = duplicates;
        }
    }

    public class RucksackReorganization
    { 
        public List<Rucksack> RucksackList { get; set; } = new();
        public char[] AddRucksackAndGetWrongSortedType(string content)
        {
            Rucksack rucksack = new(content);
            rucksack.FindWrongSortedTypes();
            RucksackList.Add(rucksack);
            return rucksack.WrongSortedTypes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3RucksackReorganization.Console
{
    public class RucksackType
    {
        public RucksackCompartment FirstCompartment { get; set; }
        public RucksackCompartment SecondCompartment { get; set; }
        public char[] WrongSortedTypes { get; set; }

        public char[] GetTypesInBothCompartments()
        {
            char[] firstTypes = FirstCompartment.GetTypes();
            char[] secondTypes = SecondCompartment.GetTypes();

            char[] combinedArray = new char[firstTypes.Length + secondTypes.Length];
            Array.Copy(firstTypes, combinedArray, firstTypes.Length);
            Array.Copy(secondTypes, 0, combinedArray, firstTypes.Length, secondTypes.Length);

            char[] duplicates = combinedArray.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToArray();

            WrongSortedTypes = duplicates;

            return duplicates;
        }
    }

    public class RucksackCompartment
    {
        public char[] Content { get; set; }

        public RucksackCompartment()
        {

        }
        public char[] GetTypes()
        {
            return Content.Distinct().ToArray();
        }
    }
    public class RucksackReorganization
    {
        public List<RucksackType> RucksackList { get; set; } = new();

        public RucksackReorganization()
        {

        }
        public void AddRucksack(string content)
        {
            string first = content.Substring(0, content.Length / 2);
            string second = content.Substring(content.Length / 2, content.Length / 2);

            RucksackCompartment firstCompartment = new() { Content = first.ToCharArray() };
            RucksackCompartment secondCompartment = new() { Content = second.ToCharArray() };

            firstCompartment.GetTypes();
            secondCompartment.GetTypes();

            RucksackType rucksack = new RucksackType()
            {
                FirstCompartment = firstCompartment,
                SecondCompartment = secondCompartment
            };

            char[] combinedChars = rucksack.GetTypesInBothCompartments();

            RucksackList.Add(rucksack);
        }
    }
}

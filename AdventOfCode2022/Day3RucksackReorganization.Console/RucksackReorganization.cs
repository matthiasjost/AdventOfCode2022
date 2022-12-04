using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Day3RucksackReorganization.Console
{
    public class RucksackReorganization
    {
        private RucksackCompartment FirstCompartment { get; set; } = null;
        private RucksackCompartment SecondCompartment { get; set; } = null;
        private char[] WrongSortedItems { get; set; } = new char[] { };
        private int WrongSortedScore { get; set; }

        public void StoreInCompartment(string allContents)
        {
            string first = allContents.Substring(0, allContents.Length / 2);
            string second = allContents.Substring(allContents.Length / 2, allContents.Length / 2);

            FirstCompartment = new() { Content = first.ToCharArray() };
            SecondCompartment = new() { Content = second.ToCharArray() };
        }

        public char[] FindWrongStored()
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

            WrongSortedItems = duplicates;
            return WrongSortedItems;
        }

        public int CalculateWrongSortedPriority()
        {
            foreach (char typeItem in WrongSortedItems)
            {

                int typeValue = (int)typeItem;

                if (typeValue >= 97)
                {
                    typeValue = typeValue - 97 + 26;
                }

                WrongSortedScore += typeValue;
            }
            return WrongSortedScore;
        }
    }
}

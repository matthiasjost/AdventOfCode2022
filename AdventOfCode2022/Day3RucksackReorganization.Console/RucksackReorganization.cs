using System;
using System.Collections;
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

        public char[] WrongSorted { get; set; }
        public int WrongScore { get; set; }

        public void StoreInCompartment(string allContents)
        {
            string first = allContents.Substring(0, allContents.Length / 2);
            string second = allContents.Substring(allContents.Length / 2, allContents.Length / 2);

            FirstCompartment = new() { Content = first.ToCharArray() };
            SecondCompartment = new() { Content = second.ToCharArray() };
        }

        public void FindWrongStored()
        {
            char[] firstTypes = FirstCompartment.GetDistinctItemTypes();
            char[] secondTypes = SecondCompartment.GetDistinctItemTypes();

            char[] combinedArray = new char[firstTypes.Length + secondTypes.Length];
            Array.Copy(firstTypes, combinedArray, firstTypes.Length);
            Array.Copy(secondTypes, 0, combinedArray, firstTypes.Length, secondTypes.Length);

            WrongSorted = combinedArray.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToArray();
        }

        /*
        Lowercase item types a through z have priorities 1 through 26.
        Uppercase item types A through Z have priorities 27 through 52.
        */
        public int CalculateWrongSortedPriority()
        {
            int calculatedValue = 0;

            foreach (char typeItem in WrongSorted)
            {
                int typeValue = (int)typeItem;

                if (typeValue >= (int)('A') && typeValue <= (int)('Z'))
                {
                    calculatedValue = typeValue - 65 + 27;
                }
                else if  (typeValue >= (int)('a') && typeValue <= (int)('z'))
                {
                    calculatedValue = typeValue - 96;
                }

                WrongScore += calculatedValue;
            }

            return WrongScore;
        }
    }
}

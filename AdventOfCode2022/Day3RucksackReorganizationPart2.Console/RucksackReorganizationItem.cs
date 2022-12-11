using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Day3RucksackReorganizationPart2.Console
{
    public class RucksackReorganizationItem
    {
        private RucksackCompartment FirstRucksack{ get; set; }
        private RucksackCompartment SecondRucksack { get; set; }
        private RucksackCompartment ThirdRucksack { get; set; }

        public char WrongSorted { get; set; }
        public int WrongScore { get; set; }

        public void StoreInThreeRucksacks(string firstContents, string secondContents, string thirdContents)
        {
            FirstRucksack = new RucksackCompartment();
            FirstRucksack.Content = firstContents.ToCharArray();

            SecondRucksack = new RucksackCompartment();
            SecondRucksack.Content = secondContents.ToCharArray();

            ThirdRucksack = new RucksackCompartment();
            ThirdRucksack.Content = thirdContents.ToCharArray();
        }

        public void FindWrongStored()
        {
            WrongSorted = FirstRucksack.Content.Intersect(SecondRucksack.Content).Intersect(ThirdRucksack.Content)
                .FirstOrDefault();
        }

        /*
        Lowercase item types a through z have priorities 1 through 26.
        Uppercase item types A through Z have priorities 27 through 52.
        */
        public int CalculateWrongSortedPriority()
        {
            int calculatedValue = 0;
            WrongScore = 0;

            int typeValue = (int)WrongSorted;

            if (typeValue >= (int)('A') && typeValue <= (int)('Z'))
            {
                calculatedValue = typeValue - 65 + 27;
            }
            else if (typeValue >= (int)('a') && typeValue <= (int)('z'))
            {
                calculatedValue = typeValue - 96;
            }

            WrongScore += calculatedValue;
        

            return WrongScore;
        }
    }
}

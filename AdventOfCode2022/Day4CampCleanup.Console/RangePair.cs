using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CampCleanup.Console
{
    public class RangePair
    {
        public RangeItem Left { get; set; } = new RangeItem();
        public RangeItem Right { get; set; } = new RangeItem();

        public bool CheckIfOneContainsTheOther()
        {
            return true;
        }
        public bool CheckIfRightContainsLeft()
        {


            return true;
        }
        public bool CheckIfLeftContainsRight()
        {
            IEnumerable<int> firstRange = Enumerable.Range(Left.From, Left.To-Left.From+1);
            IEnumerable<int> secondRange = Enumerable.Range(Right.From, Right.To-Right.From+1);
            IEnumerable<int> intersection = firstRange.Intersect(secondRange);

            if (intersection.Count() == secondRange.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}

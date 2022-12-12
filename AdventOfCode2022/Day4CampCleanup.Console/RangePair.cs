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
            IEnumerable<int> intersection = Left.Range.Intersect(Right.Range);

            if (intersection.Count() == Right.Range.Count())
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

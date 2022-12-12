using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CampCleanup.Console
{
    public class RangeItem
    {
        public IEnumerable<int> Range { get; set; }
        public void SetRange(int from, int to)
        {
            Range = Enumerable.Range(from, to - from + 1);
        }
    }
}

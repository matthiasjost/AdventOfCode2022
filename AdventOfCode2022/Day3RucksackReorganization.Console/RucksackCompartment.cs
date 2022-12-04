using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3RucksackReorganization.Console
{
    public class RucksackCompartment
    {
        public char[] Content { get; set; }
        public char[] GetDistinctItemTypes()
        {
            return Content.Distinct().ToArray();
        }
    }
}

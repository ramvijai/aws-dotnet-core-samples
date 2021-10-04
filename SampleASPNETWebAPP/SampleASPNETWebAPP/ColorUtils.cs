using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPNETWebAPP
{
    public class ColorUtils
    {
        public int PickRandomNumber(int limit)
        {
            var random = new Random();
            var index = random.Next(limit) + 1;
            return index;
        }
    }
}

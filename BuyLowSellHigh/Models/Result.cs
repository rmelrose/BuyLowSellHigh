using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLowSellHigh.Models
{
    internal class Result
    {
        int lowDay { get; set; }

        double low { get; set; }

        int highDay { get; set; }

        double high { get; set; }

        public Result(int lowDay, double low, int highDay, double high)
        {
            this.lowDay = lowDay;
            this.low = low;
            this.highDay = highDay;
            this.high = high;

        }

        public override string ToString()
        {
            return string.Format("{0}({1}), {2}({3})", this.lowDay, this.low, this.highDay, this.high);
        }
    }
}

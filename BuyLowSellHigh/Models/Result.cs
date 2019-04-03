namespace BuyLowSellHigh.Models
{
    internal class Result
    {
        /// <summary>
        /// Gets or sets the low day.
        /// </summary>
        /// <value>
        /// The low day.
        /// </value>
        int LowDay { get; set; }

        /// <summary
        /// >Gets or sets the low value.
        /// </summary>
        /// <value>
        /// The low value.
        /// </value>
        double Low { get; set; }

        /// <summary>
        /// Gets or sets the high day.
        /// </summary>
        /// <value>
        /// The high day.
        /// </value>
        int HighDay { get; set; }

        /// <summary>
        /// Gets or sets the high calue.
        /// </summary>
        /// <value>
        /// The high.
        /// </value>
        double High { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        /// <param name="lowDay">The low day.</param>
        /// <param name="low">The low.</param>
        /// <param name="highDay">The high day.</param>
        /// <param name="high">The high.</param>
        public Result(int lowDay, double low, int highDay, double high)
        {
            this.LowDay = lowDay;
            this.Low = low;
            this.HighDay = highDay;
            this.High = high;

        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}({1}), {2}({3})", this.LowDay, this.Low, this.HighDay, this.High);
        }
    }
}

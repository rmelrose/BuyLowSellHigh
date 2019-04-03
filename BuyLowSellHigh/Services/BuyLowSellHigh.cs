using BuyLowSellHigh.Models;
using System;
using System.Collections.Generic;

namespace BuyLowSellHigh
{
    /// <summary>
    /// The main application logic. Used to find the best day to buy then best day to sell stock.
    /// </summary>
    internal class BuyLowSellHigh : IBuyLowSellHigh
    {
        /// <summary>
        /// The injected FileImport.
        /// </summary>
        private readonly IFileImport fileImport;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyLowSellHigh"/> class.
        /// </summary>
        /// <param name="fileImport"> The file import.</param>
        public BuyLowSellHigh(IFileImport fileImport)
        {
            this.fileImport = fileImport;
        }

        /// <summary>
        /// Runs the main logic of BuyLowSellHigh.
        /// </summary>
        public void Run()
        {
            while (true)
            {
                Result result = GetResult(this.fileImport.GetData());

                Console.WriteLine(result.ToString());
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <param name="shares">The shares.</param>
        /// <returns>
        /// The Result containing the best day to buy and sell the shares.
        /// </returns>
        private Result GetResult(List<double> shares)
        {
            int low = 0;
            int high = 0;
            double delta = 0;

            //We need to loop through all of the days of the month and find the delta between other days.
            for (int i = 0; i < shares.Count; i++)
            {
                // We need to compare this day (i) to all subsequent days (j).
                for(int j = (i + 1); j < shares.Count; j++)
                {
                    //If the delta is positive and greater than the current delta we have a new best low/high.
                    if ((shares[j] - shares[i]) > 0 && (shares[j] - shares[i]) > delta)
                    {
                        low = i;
                        high = j;
                        delta = shares[j] - shares[i];
                    }
                }
            }

            return new Result((low + 1), shares[low], (high + 1), shares[high]);
        }
    }
}

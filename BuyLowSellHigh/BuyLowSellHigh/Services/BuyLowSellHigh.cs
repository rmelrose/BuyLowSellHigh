using BuyLowSellHigh.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLowSellHigh
{
    internal class BuyLowSellHigh : IBuyLowSellHigh
    {
        private readonly IFileImport fileImport;

        public BuyLowSellHigh(IFileImport fileImport)
        {
            this.fileImport = fileImport;
        }

        public void Run()
        {
            Result result = getResult(this.fileImport.getData());

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        private Result getResult(List<double> shares)
        {
            int low = 0;
            int high = 0;
            double delta = 0;

            for (int i = 0; i < shares.Count; i++)
            {
                // We need to compare this to all others after it.
                for(int j = (i + 1); j < shares.Count; j++)
                {
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

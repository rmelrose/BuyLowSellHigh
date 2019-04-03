using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLowSellHigh
{
    /// <summary>
    /// Interface used to implement the retreival of data.
    /// Could be extended to support SQL etc.
    /// </summary>
    public interface IFileImport
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>
        /// A List of Doubles - the stock values.
        /// </returns>
        List<double> GetData();
    }
}

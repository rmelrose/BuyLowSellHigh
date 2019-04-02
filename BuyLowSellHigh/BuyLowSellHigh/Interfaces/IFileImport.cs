using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLowSellHigh
{
    public interface IFileImport
    {
        List<double> getData();
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace BuyLowSellHigh
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IBuyLowSellHigh, BuyLowSellHigh>()
                .AddSingleton<IFileImport, FileImport>()
                .BuildServiceProvider();


            var service = serviceProvider.GetService<IBuyLowSellHigh>();
            service.Run();
        }
    }
}

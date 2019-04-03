using Microsoft.Extensions.DependencyInjection;

namespace BuyLowSellHigh
{
    /// <summary>
    /// Entry point. Used for setting up the Dependency Injection.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Register the concretions for our interfaces.
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IBuyLowSellHigh, BuyLowSellHigh>()
                .AddSingleton<IFileImport, FileImport>()
                .BuildServiceProvider();

            // Get the concretion and run the application.
            var service = serviceProvider.GetService<IBuyLowSellHigh>();
            service.Run();
        }
    }
}

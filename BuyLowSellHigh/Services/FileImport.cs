using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace BuyLowSellHigh
{
    internal class FileImport : IFileImport
    {
        public List<double> getData()
        {
            Console.Write("Enter File Path: ");
            var filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    List<double> shares = new List<double>();

                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var vals = line.Split(',');

                        Array.ForEach(vals, item => shares.Add(Convert.ToDouble(item)));
                    }

                    return shares;
                }
            }
            else
            {
                Console.WriteLine("File does not exist - Please check and try again.");
                this.getData();

                return null;
            }
        }
    }
}
